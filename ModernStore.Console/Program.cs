using MordenStore.Domain.Entities;
using MordenStore.Domain.ValueObject;
using System;

namespace ModernStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("lazaro", "adm123");
            var name = new Name("Lázaro", "Campos");
            var email = new Email("lazaro@email.com");
            var customer = new Customer(user, name, email, null);

            var mouse = new Product("mouse", 299, "mouse.jpg", 20);
            var mousepad = new Product("mousepad", 99, "mousepad.jpg", 20);
            var teclado = new Product("teclado", 599, "teclado.jpg", 20);

            var order = new Order(customer, 8, 10);
            order.AddItem(new OrderItem(mouse, 2));
            order.AddItem(new OrderItem(mousepad, 2));
            order.AddItem(new OrderItem(teclado, 2));

            Console.WriteLine($"Numero do pedido :{ order.Number}");
            Console.WriteLine($"Data :{order.CreationDate :dd/MM/yyyy}");
            Console.WriteLine($"Desconto :{order.Discount}");
            Console.WriteLine($"Taxa de entrega :{order.DeliveryFee}");
            Console.WriteLine($"Subtotal :{order.SubTotal()}");
            Console.WriteLine($"Total :{order.Total()}");
            Console.WriteLine($"Cliente :{order.Customer.ToString()}");
            Console.WriteLine($"Temos {mouse.QuantityOnHand} mouses");
            Console.WriteLine($"Temos {mousepad.QuantityOnHand} mousespads");
            Console.WriteLine($"Temos {teclado.QuantityOnHand} teclados");

            Console.ReadKey();

        }
    }
}
