using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
      
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = _context.Customer
                            .Include(x => x.Gender)
                            .Include(x => x.MembershipType)
                            .FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return View(result);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult New()
        {
            var model = new NewCustomerViewModel
            {
                DropdownListForGenders = _context.Gender.Select(g => new SelectListItem(g.Name, g.Id.ToString())),
                DropdownListForMembershipTypes = _context.MembershipType.Select(m => new SelectListItem(m.Name, m.Id.ToString()))
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(NewCustomerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.DropdownListForGenders = _context.Gender.Select(g => new SelectListItem(g.Name, g.Id.ToString()));
                model.DropdownListForMembershipTypes = _context.MembershipType.Select(m => new SelectListItem(m.Name, m.Id.ToString()));
                return View(model);
                    
            };

            var addCustomerToDb = new Customer
            {
                Name = model.Customer.Name,
                BirthDate = model.Customer.BirthDate,
                GenderId = model.Customer.GenderId,
                MembershipTypeId = model.Customer.MembershipTypeId,
                IsSubscribedToNewsLetter = model.Customer.IsSubscribedToNewsLetter
            };

            _context.Customer.Add(addCustomerToDb);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var findCustomer = _context.Customer
                                        .Include(c => c.Gender)
                                        .Include(c => c.MembershipType)
                                        .FirstOrDefault(c => c.Id == id);

            if (findCustomer == null)
            {
                return NotFound();
            }

            var model = new NewCustomerViewModel
            {
                Customer = findCustomer,
                DropdownListForGenders = _context.Gender.Select(g => new SelectListItem()
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                DropdownListForMembershipTypes = _context.MembershipType.Select(m => new SelectListItem(m.Name, m.Id.ToString())),
            };



            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(NewCustomerViewModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            var findCustomer = _context.Customer.FirstOrDefault(c => c.Id == model.Customer.Id);

            if (findCustomer == null)
            {
                return NotFound();
            }

            findCustomer.Name = model.Customer.Name;
            findCustomer.BirthDate = model.Customer.BirthDate;
            findCustomer.GenderId = model.Customer.GenderId;
            findCustomer.MembershipTypeId = model.Customer.MembershipTypeId;
            findCustomer.IsSubscribedToNewsLetter = model.Customer.IsSubscribedToNewsLetter;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
