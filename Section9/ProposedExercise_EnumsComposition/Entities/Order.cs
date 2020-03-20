using System;
using System.Collections.Generic;
using ProposedExercise_EnumsComposition.Entities.Enums;
using System.Text;
using System.Globalization;

namespace ProposedExercise_EnumsComposition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> ListItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            ListItems = new List<OrderItem>();
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            ListItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            ListItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in ListItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss ")}");
            stringBuilder.AppendLine($"Order status: {Status}");
            stringBuilder.AppendLine($"Client: {Client}");
            stringBuilder.AppendLine("Order Items");

            foreach (OrderItem item in ListItems)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.AppendLine($"Total Price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return stringBuilder.ToString();
        }
    }
}
