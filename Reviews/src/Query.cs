

public class Query {
    public List<Review> GetReviews(
        [Service] ReviewService reviewService, string productId
    ) => reviewService.GetReviews(productId);
}