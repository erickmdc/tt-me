using Microsoft.AspNetCore.Mvc;
using ttme;

namespace web_app_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet()]
        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }

        [HttpGet("{id}")]
        public Product? GetProduct(int id)
        {
            return productService.GetProduct(id);
        }

        [HttpPost]
        public int PostProduct([FromBody] ProductRequest product)
        {
            return productService.AddProduct(product.Name, product.Price);
        }

        [HttpPut("{id}")]
        public Product PutProduct(int id, [FromBody] ProductRequest product)
        {
            return productService.UpdateProduct(id, product.Name, product.Price);
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            productService.DeleteProduct(id);
        }
    }
}
