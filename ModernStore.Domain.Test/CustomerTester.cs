using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MordenStore.Domain.Entities;
using MordenStore.Domain.ValueObject;

namespace ModernStore.Domain.Test
{
    [TestClass]
    public class CustomerTester
    {
        [TestMethod]
        [TestCategory("Customer - NewCustomer")]
        public void GivenAnInvalidFirstNameDhoulReturnANotification()
        {
            var user = new User("lazaro", "123");
            var email = new Email("lazaro@email.com");
            var name = new Name("lazaro", "campos");
            var document = new Document("07364244581");
            var customer = new Customer(user,name,document,email,null);

            Assert.IsFalse(!customer.IsValid());
        }
    }
}
