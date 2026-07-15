using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace MyPortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index() => View(); // Summary & Extra Curriculars
        public IActionResult Resume() => View(); // Education, Skills, Exp, Achievements, Publications
        public IActionResult Projects() => View(); // Project Section

        // Download CV Action Method
        [HttpGet]
        public IActionResult DownloadCV()
        {
            string filePath = Path.Combine(_env.WebRootPath, "docs", "My_CV.pdf");
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("The requested CV file is not found on the server.");
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/pdf", "My_Resume_CV.pdf");
        }
    }
}