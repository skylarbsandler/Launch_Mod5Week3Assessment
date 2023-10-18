using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JeffersonCountyLibrary.DataAccess;
using JeffersonCountyLibrary.Models;

namespace JeffersonCountyLibrary.Controllers
{
    public class BranchesController : Controller
    {
        private readonly LibraryDbContext _context;

        public BranchesController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET: Branches
        public IActionResult Index()
        {
            if (_context.Branches == null)
            {
                return NotFound();
            }

            return View(_context.Branches.ToList());
        }

        // GET: Branches/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Branches == null)
            {
                return NotFound();
            }

            var branch = _context.Branches
                .Include(br => br.Books)
                .ThenInclude(bo => bo.CheckedOutBy)
                .FirstOrDefault(m => m.Id == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }
    }
}
