// query service getProducts from ProductService

public class Query {
    public List<Product> GetProducts(
        [Service] ProductService productService
    ) => productService.GetProducts();

    // get single product by id
    public Product GetProduct(
        [Service] ProductService productService, string productId
    ) => productService.GetProduct(productId);
}