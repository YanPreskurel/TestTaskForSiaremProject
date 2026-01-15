using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebContactsOperations.Models;

namespace WebContactsOperations.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
