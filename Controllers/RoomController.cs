using HotelManagementSystem.Data;
using HotelManagementSystem.Models.Room;
using HotelManagementSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Controllers
{
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Room
        public async Task<IActionResult> Index()
        {
            var categories = await _context.RoomCategories.ToListAsync();
            return View(categories);
        }

        // GET: Room/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.RoomCategories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            
            if (category == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms
                .Where(r => r.CategoryId == id && r.Status == "available")
                .ToListAsync();

            var viewModel = new RoomDetailViewModel
            {
                Category = category,
                AvailableRooms = rooms
            };

            return View(viewModel);
        }

        // GET: Room/Category/5
        public async Task<IActionResult> Category(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.RoomCategories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            
            if (category == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms
                .Where(r => r.CategoryId == id)
                .ToListAsync();

            var viewModel = new RoomCategoryViewModel
            {
                Category = category,
                Rooms = rooms
            };

            return View(viewModel);
        }
    }
}