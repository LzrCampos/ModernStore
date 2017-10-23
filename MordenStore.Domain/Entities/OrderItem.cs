using FluentValidator;
using ModernStore.Share.Entities;
using System;

namespace MordenStore.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Products product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;

            new ValidationContract<OrderItem>(this)
                .IsGreaterThan(x => x.Quantity, 1);
        }

        public Products Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public decimal Total() => Price * Quantity;

    }
}
