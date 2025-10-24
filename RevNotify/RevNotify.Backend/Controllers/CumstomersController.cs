using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevNotify.Backend.Data;
using RevNotify.Shared.Entites;

namespace RevNotify.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CumstomersController : ControllerBase
    {
        private readonly DataContext _context;

        public CumstomersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Customers.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return Ok(customer);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Customer customer)
        {
            var currentcustomer = await _context.Customers.FindAsync(customer.Id);
            if (currentcustomer == null)
            {
                return NotFound();
            }
            currentcustomer.Name = customer.Name;

            _context.Customers.Update(currentcustomer);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}