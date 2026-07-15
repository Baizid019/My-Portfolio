using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Data;
using MyPortfolioProject.Models;
using System.Threading.Tasks;

namespace MyPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ask(ContactMessage model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Thank you! Your question has been submitted successfully.";
                return RedirectToAction(nameof(Index));
            }
            return View("Index", model);
        }
    }
}