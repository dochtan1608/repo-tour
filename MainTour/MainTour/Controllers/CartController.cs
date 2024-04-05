
using MainTour.Data;
using MainTour.Infrastucture;
using MainTour.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace MainTour.Controllers
{
    public class CartController : Controller
    {
        public Cart? Cart { get; set; }
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View("Cart", HttpContext.Session.GetJSon<Cart>("cart"));
        }
        public IActionResult AddToCart(int productID)
        {

            Product? product = _context.Products
 .FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJSon<Cart>("cart")??new Cart();
                Cart.AddItem(product, 1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }

        public IActionResult UpdateCart(int productID)
        {

            Product? product = _context.Products
 .FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJSon<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, -1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }

        public IActionResult RemoveFromCart(int productID)
        {

            Product? product = _context.Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJSon<Cart>("cart");
                Cart.RemoveLine(product);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }
    }
}
