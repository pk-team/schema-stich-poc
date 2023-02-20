

public class ReviewService {

    public List<Review> GetReviews(string productId) {
        return new List<Review> {
            new Review(productId, "Great product", "I really like this product", 5),
            new Review(productId, "Not so great", "I don't like this product", 1)
        };
    }

}

public record Review(string ProductId, string Title, string Content, int Rating);