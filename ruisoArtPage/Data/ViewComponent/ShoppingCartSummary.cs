using Microsoft.AspNetCore.Mvc;
using ruisoArtPage.Data.Cart;

namespace ruisoArtPage.Data.ViewComponents
{   public class ShoppingCartSummary: ViewComponent{
        public ApplicationDbContext _context {get; set;}
        private readonly ShoppingCart _shoppingCart;

        //Constructor     
        public ShoppingCartSummary(ApplicationDbContext context){
            _context = context;
            _shoppingCart = new ShoppingCart(context);
        }

        //------------------------------METHODS----------------------------------
        public IViewComponentResult Invoke(){
            var items = _shoppingCart.GetShoppingCartItems();
            return View(items.Count);
        }
    }
    
}