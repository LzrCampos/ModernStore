using ModernStore.Share.Entities;
using System;

namespace MordenStore.Domain.Entities
{
    public class Products : Entity
    {
        public Products(string title, decimal price, string image, int quantityOnHand)
        {
            Title = title;
            Price = price;
            Image = image;
            QuantityOnHand = quantityOnHand;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }
        public int QuantityOnHand { get; private set; }
    }
}
