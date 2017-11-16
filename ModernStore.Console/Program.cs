using MordenStore.Domain.Commands;
using MordenStore.Domain.Entities;
using MordenStore.Domain.Repositories;
using MordenStore.Domain.ValueObject;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ModernStore.ConsoleApp
{
   class Program
    {
       static void Main(string[] args)
        {
//            var command = new RegisterOrderCommand
//            {
//                Customer = Guid.NewGuid(),
//                DeliveryFee = 8,
//                Discount = 10,
//                Items = new List<RegisterOrderItemCommand>
//                {
//                    new RegisterOrderItemCommand
//                    {
//                        Product = Guid.NewGuid(),
//                        Quantity = 5
//                    }
//                }
//            };

//            GenerateOrder(
//                new FakeCustomerRepository(),
//                new FakeProductRepository(),
//                new FakeOrderRepository(),
//                command);
            

//            Console.ReadKey();

//        }

//        public static void GenerateOrder(
//                ICustomerRepository customerRepository,
//                IProductRepository productRepository,
//                IOrderRepository orderRepository,
//                RegisterOrderCommand command)
//        {
//            var handler = new OrderCommandHandler(customerRepository,
//                productRepository,
//                orderRepository);

//                handler.Handle(command);

//            if (handler.IsValid())
//                System.Console.WriteLine("Pedido cadastrado com sucesso");
//        }

//        public class FakeProductRepository : IProductRepository
//        {
//            public Product Get(Guid id)
//            {
//                return new Product("Mouse", 299, "", 50);
//            }

//            public IEnumerable<Product> Get(List<Guid> Ids)
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public class FakeCustomerRepository : ICustomerRepository
//        {
//            public Customer Get(Guid id)
//            {
//                return null;
//            }

//            public Customer GetByUserId(Guid id)
//            {
//                return new Customer(
//                    new User("lazaro", "1234"),
//                    new Name("Lazaro", "Campos"),
//                    new Document("72546524135"),
//                    new Email("lazaro@email.com"),
//                    null
//                );
//            }

//            public void Update(Customer customer)
//            {

//            }
//        }

//        public class FakeOrderRepository : IOrderRepository
//        {            
//            public void Save(Order order)
//            {

//            }            
        }
    }
}
