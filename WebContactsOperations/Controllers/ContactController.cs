using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebContactsOperations.Interfaces;
using WebContactsOperations.Models;

namespace WebContactsOperations.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _contactService.GetAllAsync();

            return View(contacts);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            await _contactService.CreateAsync(contact);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Contact contact)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            await _contactService.UpdateAsync(contact);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _contactService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
