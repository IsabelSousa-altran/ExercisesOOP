using System;
using Enums_Example.Entities;
using Enums_Example.Entities.Enums;

namespace Enums_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus order1 = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(order1);
            Console.WriteLine(txt);

        }
    }
}
