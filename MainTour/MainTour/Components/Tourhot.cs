using MainTour.Data;
using Microsoft.AspNetCore.Mvc;

namespace MainTour.Components
{
    public class Tourhot:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Tourhot(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p=>p.IsTourHot==true).ToList());
        }
    }
}
