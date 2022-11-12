using FreeCourse.Services.Order.Domain.Core;
using System.Security.Cryptography.X509Certificates;

namespace FreeCourse.Services.Order.Domain.OrderAggregate
{
    public class Order: Entity, IAggregateRoot
    {
        public DateTime CreateTime { get; private set; }
        public Address Address { get; private set; }
        public string BuyerId { get; private set; }

        private readonly List<OrderItem> _orderItems;
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order(Address address, string buyerId)
        {
            _orderItems = new List<OrderItem>();
            CreateTime = DateTime.Now;
            Address = address;
            BuyerId = buyerId;
        }

        public void AddOrderItem(string productId, string productName, decimal price, string pictureUrl)
        {
            var existingProduct = _orderItems.Any(x => x.ProductId == productId);

            if (!existingProduct)
            {
                var newOrderItem = new OrderItem(productId, productName, pictureUrl, price);
                _orderItems.Add(newOrderItem);
            }
        }

        public decimal GetTotalPrice => _orderItems.Sum(x => x.Price);
    }
}
