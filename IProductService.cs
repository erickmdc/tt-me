namespace ttme;

public interface IProductService
{
    public List<Product> GetProducts();

    public Product? GetProduct(int id);

    public int AddProduct(string name, decimal price);

    public Product UpdateProduct(int id, string name, decimal price);

    public void DeleteProduct(int id);
}