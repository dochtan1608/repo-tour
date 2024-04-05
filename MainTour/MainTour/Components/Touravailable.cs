using MainTour.Data;
using Microsoft.AspNetCore.Mvc;

namespace MainTour.Components
{
    public class Touravailable:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Touravailable(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p=>p.IsTourAvailable==true).ToList());
        }
    }
}
