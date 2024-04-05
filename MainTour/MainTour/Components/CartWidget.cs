using MainTour.Data;
using MainTour.Infrastucture;
using MainTour.Models;
using Microsoft.AspNetCore.Mvc;

namespace MainTour.Components
{
    public class CartWidget:ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJSon<Cart>("cart"));
        }
    }
}
