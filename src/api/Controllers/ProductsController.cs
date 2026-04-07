using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<ProductResponseModel>> GetAllProducts(int page = 1, int pageSize = 10)
        {
            // Placeholder for getting products from a database or service
            var products = new List<ProductResponseModel>(); // Replace with actual data fetching

            var paginatedProducts = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            _logger.LogInformation("Retrieved {Count} products for page {Page} with page size {PageSize}", paginatedProducts.Count, page, pageSize);

            return Ok(paginatedProducts);
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<ProductResponseModel> GetProductById(int id)
        {
            var product = new ProductResponseModel(); // Replace with actual data fetching logic

            if (product == null)
            {
                _logger.LogWarning("Product with ID {Id} not found.", id);
                return NotFound();
            }

            _logger.LogInformation("Retrieved product with ID {Id}", id);
            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<ProductResponseModel> CreateProduct([FromBody] ProductRequestModel request)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid model state for product creation.");
                return BadRequest(ModelState);
            }

            var newProduct = new ProductResponseModel(); // Replace with actual creation logic
            _logger.LogInformation("Created new product with ID {Id}", newProduct.Id);
            return CreatedAtAction(nameof(GetProductById), new { id = newProduct.Id }, newProduct);
        }

        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] ProductRequestModel request)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid model state for product update.");
                return BadRequest(ModelState);
            }

            // Replace with actual update logic
            _logger.LogInformation("Updated product with ID {Id}", id);
            return NoContent();
        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            // Replace with actual deletion logic
            _logger.LogInformation("Deleted product with ID {Id}", id);
            return NoContent();
        }
    }

    public class ProductRequestModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class ProductResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}