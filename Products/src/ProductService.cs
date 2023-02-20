



public class ProductService {


    public List<Product> GetProducts() {
        // 3 products "Samsung Phone", "Sony headphones", "JBL speakers"
        return new List<Product> {
            new Product("1", "Samsung Phone", "A great phone", 1000),
            new Product("2", "Sony headphones", "A great headphones", 200),
            new Product("3", "JBL speakers", "A great speakers", 300)
        };
    }

    // get single product by id
    public Product GetProduct(string productId) {
        var product =  GetProducts().FirstOrDefault(p => p.ProductId == productId);
        if (product == null) {
            throw new Exception("Product not found");
        }
        return product;
    }
}

public record Product(string ProductId, string Name, string Description, decimal Price);