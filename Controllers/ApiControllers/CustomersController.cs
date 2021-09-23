using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Vidly.Data;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    //video 76
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CustomersController(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _context = applicationDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<CustomerDtos> GetAll()
        {
            return Ok(_context.Customer
                            .Include(c => c.MembershipType)
                            .Include(c => c.Gender)
                            .Select(_mapper.Map<Customer, CustomerDtos>)
                            .OrderBy(x => x.Name)
                            .ToList());

        }

        [HttpGet("{id}")]
        public ActionResult<CustomerDtos> Get(int id)
        {
            var result = _context.Customer.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Customer, CustomerDtos>(result));
        }

        [HttpPost]
        public ActionResult<CustomerDtos> Create(CustomerDtos customerDtos)
        {
            if (!ModelState.IsValid) { return BadRequest(); }


            var customer = _mapper.Map<CustomerDtos, Customer>(customerDtos);

            _context.Customer.Add(customer);
            _context.SaveChanges();

            customerDtos.Id = customer.Id;
            return CreatedAtAction(nameof(Get), new { id = customerDtos.Id }, customerDtos);
        }

        [HttpPut]
        public ActionResult<CustomerDtos> Update(int id, CustomerDtos customerDtos)
        {
            if (!ModelState.IsValid) { return BadRequest(); }

            var findCustomerFromDb = _context.Customer.FirstOrDefault(x => x.Id == id);

            if (findCustomerFromDb == null)
                return NotFound();

            var result = _mapper.Map(customerDtos, findCustomerFromDb);

            _context.SaveChanges();
            return Ok(customerDtos);

        }

        [HttpDelete("{id}")]
        public ActionResult<CustomerDtos> Delete(int id)
        {
            var cusObj = _context.Customer.FirstOrDefault(x => x.Id == id);
            if (cusObj == null)
            {
                return Json(new { success = false, message = "Error why deleting." });
            }

            var cusDto = _mapper.Map<Customer, CustomerDtos>(cusObj);
            _context.Customer.Remove(cusObj);
            _context.SaveChanges();
            return Json(new { success = true, message = "Delete successful" });

        }



    }
}
