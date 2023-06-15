using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Controllers;
using ruisoArtPage.Models;

namespace ruisoArtPage.Data.Cart{
    public class ShoppingCart{
        public ApplicationDbContext _context {get; set;}
        public string ShoppingCartId {get; set;}
        public List<ShoppingCartItem> ShoppingCartItems {get; set;}

        public ShoppingCart(ApplicationDbContext context){
            _context = context;
        } 
        //-----------------------------METHODS-----------------------------------
        //-----------------------------get shopping CART--------------------------------
        public static ShoppingCart GetShoppingCart(IServiceProvider service){
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var httpcontext = service.GetService<ApplicationDbContext>();

            var cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(httpcontext) { ShoppingCartId = cartId };
        }
        //--------------------------------------get SHOPPING CART ITEMS--------------------------------------
        public List<ShoppingCartItem> GetShoppingCartItems(){
            return ShoppingCartItems ?? (
                ShoppingCartItems = _context.ShoppingCartItem
                    .Where(s => s.ShoppingCartId == ShoppingCartId)
                    .Include(p => p.Product)
                    .ToList()
            );
        }
        //-----------------------------TOTAL PRICE ITEMS--------------------------------------
        public decimal GetShoppingCartTotal(){
            var total = _context.ShoppingCartItem
                .Where(s => s.ShoppingCartId == ShoppingCartId)
                .Select(s => s.Product.price * s.Amount)
                .Sum();
            return (decimal)total;
        }
        //-----------------------------ADD ITEM--------------------------------------
        public void AddItemCart(Product product){
            var shoppingCartItem = _context.ShoppingCartItem.FirstOrDefault(
                s => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId
            );
            if(shoppingCartItem == null){
                shoppingCartItem = new ShoppingCartItem {
                    ShoppingCartId = ShoppingCartId, 
                    Product = product,
                    Amount = 1
                };
                _context.ShoppingCartItem.Add(shoppingCartItem);
            }
            else{
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }
        //-----------------------------REMOVE ITEM--------------------------------------
        public void RemoveItemFromCart(Product product){
            var shoppingCartItem = _context.ShoppingCartItem.FirstOrDefault(
                s => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId
            );
            if(shoppingCartItem != null){
                if(shoppingCartItem.Amount > 1){
                    shoppingCartItem.Amount--;
                }else{
                    _context.ShoppingCartItem.Remove(shoppingCartItem);
                }
                _context.SaveChanges();
            }
        }
        //-----------------------------CLEAR ITEMS FROM SHOPPING CART--------------------------------------
        public void ClearShoppingCart(){
            var items = _context.ShoppingCartItem
                .Where(s => s.ShoppingCartId == ShoppingCartId)
                .ToList();
            _context.ShoppingCartItem.RemoveRange(items);
            _context.SaveChanges();
        }
    }
}