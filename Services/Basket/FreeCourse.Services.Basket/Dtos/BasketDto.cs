namespace FreeCourse.Services.Basket.Dtos
{
    public class BasketDto
    {
        public string UserId { get; set; }
        public string DiscoundCode { get; set; }
        public List<BasketItemDto> basketItems { get; set; }
        public decimal TotalPrice {
            get => basketItems.Sum(q => q.Price * q.Quantity); 
        }
    }
}
