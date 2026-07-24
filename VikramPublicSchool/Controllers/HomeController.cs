using Microsoft.AspNetCore.Mvc;
using VikramPublicSchool.Models;

namespace VikramPublicSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: /  and  /Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/About
        public IActionResult About()
        {
            return View();
        }

        // GET: /Home/Gallery
        public IActionResult Gallery()
        {
            return View();
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            return View(new ContactFormModel());
        }

        // POST: /Home/Contact  (UI only - no backend persistence, per requirements)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                // No database / backend as per requirements.
                // In a real application this would send an email or save an enquiry.
                ViewBag.SubmissionSuccess = true;
                ModelState.Clear();
                return View(new ContactFormModel());
            }

            return View(model);
        }

        // GET: /Home/Admission
        public IActionResult Admission()
        {
            return View();
        }

        // GET: /Home/Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
