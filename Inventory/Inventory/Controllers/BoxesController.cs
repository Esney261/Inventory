using Inventory.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Controllers
{
    public class BoxesController: Controller
    {
        private readonly DataContext _context;

        public BoxesController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Boxes.ToListAsync());  
        }
    }
}
