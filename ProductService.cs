using Microsoft.Extensions.Caching.Memory;

namespace ttme;

public class ProductService : IProductService
{
    private ProductStore productStore;

    public ProductService(ProductStore productStore)
    {
        this.productStore = productStore;
    }
    
    public List<Product> GetProducts()
    {
        return productStore.Products;
    }

    public Product? GetProduct(int id)
    {
        return productStore.Products.FirstOrDefault(p => p.Id == id);
    }

    public int AddProduct(string name, decimal price)
    {
        var newProduct = new Product
        {
            Id = productStore.Products.Count + 1,
            Name = name,
            Price = price
        };

        productStore.Products.Add(newProduct);
        return newProduct.Id;
    }

    public Product UpdateProduct(int id, string name, decimal price)
    {
        var currentProduct = productStore.Products.FirstOrDefault(p => p.Id == id);
        
        if(currentProduct == null)
            throw new Exception("Product not found");
        
        currentProduct.Name = name;
        currentProduct.Price = price;
        return currentProduct;
    }

    public void DeleteProduct(int id)
    {
        productStore.Products.RemoveAll(p => p.Id == id);
    }
}