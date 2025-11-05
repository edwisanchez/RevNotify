using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevNotify.Backend.Data;
using RevNotify.Shared.Entites;

namespace RevNotify.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCategoryController : Controller
    {
        private readonly DataContext _context;

        public ProductCategoryController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.ProductCategories.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var productCategory = await _context.ProductCategories.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }
            return Ok(productCategory);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ProductCategory productCategory)
        {
            _context.ProductCategories.Add(productCategory);
            await _context.SaveChangesAsync();
            return Ok(productCategory);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(ProductCategory productCategory)
        {
            var currentproductCategory = await _context.ProductCategories.FindAsync(productCategory.Id);
            if (currentproductCategory == null)
            {
                return NotFound();
            }
            currentproductCategory.CategoryName = productCategory.CategoryName;

            _context.ProductCategories.Update(currentproductCategory);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var productCategory = await _context.Products.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }
            _context.Remove(productCategory);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}