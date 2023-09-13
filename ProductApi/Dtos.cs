namespace ProductApi
{
    public class Dtos
    {
        public record ProductDto(Guid Id, string ProductName, int ProductPrice, DateTimeOffset CreateTime);
        public record CreateProductDto(string ProductName, int ProductPrice);

        public record PullProductDto(string ProductName, int ProductPrice);
    }
}
