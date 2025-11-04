using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevNotify.Backend.Data;
using RevNotify.Shared.Entites;

namespace RevNotify.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly DataContext _context;

        public ProductsController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Product product)
        {
            var currentcustomer = await _context.Customers.FindAsync(product.Id);
            if (currentcustomer == null)
            {
                return NotFound();
            }
            currentcustomer.Name = product.ProductName;

            _context.Customers.Update(currentcustomer);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}