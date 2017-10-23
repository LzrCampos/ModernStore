using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MordenStore.Domain.Entities;
using MordenStore.Domain.ValueObject;

namespace ModernStore.Domain.Test
{
    /// <summary>
    /// Descrição resumida para OrderTester
    /// </summary>
    [TestClass]
    public class OrderTester
    {
        [TestMethod]
        [TestCategory("Order - NewOrder")]
        public void GivenAnOutOfStovkProductItShowIdReturnAnError()
        {
            var user = new User("lazaro", "adm123");
            var name = new Name("Lázaro", "Campos");
            var email = new Email("lazaro@email.com");
            var customer = new Customer(user, name, email, null);

            var mouse = new Product("mouse", 299, "mouse.jpg", 0);

            var order = new Order(customer, 8, 10);
            order.AddItem(new OrderItem(mouse, 2));

            Assert.IsFalse(order.IsValid());
        }

    }
}
