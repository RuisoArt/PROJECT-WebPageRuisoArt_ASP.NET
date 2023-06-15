using Microsoft.AspNetCore.Mvc;
using ruisoArtPage.Controllers;
using ruisoArtPage.Models;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Cart;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Data.ViewModels;

namespace ruisoArtPage.Controllers{
    public class OrderController: Controller{
        private readonly ApplicationDbContext _context;
        private readonly ProductController _productController;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(ApplicationDbContext context){
            _context = context;
            _productController = new ProductController(context);
            _shoppingCart = new ShoppingCart(context);
        }
        // -------------------------------METHODS---------------------------------
        public IActionResult Index(){
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);

            var orders = GetOrdersByUserId(userId, userRole);

            return View(orders);
        }
        public List<Order> GetOrdersByUserId(string userId, string userRole) {
            var orders = _context.Order
               .Include( o => o.Items)
               .ThenInclude( p => p.Product)
               .Include(u => u.User)
               .ToList();
            
            if (userRole != UserRoles.Admin){
                orders = orders.Where( o => o.UserId == userId).ToList();
            }

            return orders;
        }
        // --------------------------------------------------------------------
        public IActionResult ShoppingCart(){
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM (){
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };
            return View(response);
        }
        //-----------------------------------------------------------------------
        //[Authorize]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult AddItemToShoppingCart(int id){
            if(User.Identity.IsAuthenticated){
                var item = _productController.GetProductById(id);

                if (item != null){
                    _shoppingCart.AddItemCart(item);
                }

                return RedirectToAction(nameof(ShoppingCart));
            }else{
                return View("MyFuckingLogin");
            }
        }
        //-----------------------------------------------------------------------
        public IActionResult RemoveItemFromShoppingCart(int id){
            if(User.Identity.IsAuthenticated){
                var item = _productController.GetProductById(id);

                if (item != null){
                    _shoppingCart.RemoveItemFromCart(item);
                }

                return RedirectToAction(nameof(ShoppingCart));
            }else{
                return RedirectToAction("/Identity/Account/Login");
            }
        }
        //-----------------------------------------------------------------------
        public IActionResult CompleteOrder(){

            if(User.Identity.IsAuthenticated){
                var items = _shoppingCart.GetShoppingCartItems();
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                string userEmail = User.FindFirstValue(ClaimTypes.Email);

                StoreOrder(items, userId, userEmail);
                _shoppingCart.ClearShoppingCart();
                
                return View("OrderCompleted");
            }else{
                return Redirect("/Identity/Account/Login");
            }

        }
        public void StoreOrder(List<ShoppingCartItem> items, string userId, string userEmail){
            var order = new Order{
                UserId = userId,
                Email = userEmail,
                CreateDate = DateTime.Now,
            };
            _context.Order.Add(order);
            _context.SaveChanges();

            foreach (var item in items){
                var orderItem = new OrderItem(){
                    Amount = item.Amount,
                    ProductId = item.Product.Id,
                    OrderId = order.Id,
                    Price = (decimal)item.Product.price,
                };
                _context.OrderItem.Add(orderItem);
            }
            _context.SaveChanges();
        }
        //-----------------------------------------------------------------------
    }
}