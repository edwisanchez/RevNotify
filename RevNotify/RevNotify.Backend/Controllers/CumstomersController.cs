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
            var country = await _context.Customers.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return Ok(customer);
        }
    }
}