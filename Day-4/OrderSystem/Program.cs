using System;

namespace OrderSystem
{
    // Step 1: Enum to represent OrderStatus
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    // Step 2: Struct to represent Location
    public struct Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    // Step 3: Payment interface
    interface IPayment
    {
        void ProcessPayment(double amount);
        void RefundPayment(double amount);
        bool MakePayment(double amount);
    }

    // Credit Card Payment class
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Credit Card payment of {amount} processed.");
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Credit Card refund of {amount} processed.");
        }

        public bool MakePayment(double amount)
        {
            ProcessPayment(amount);
            return true;
        }
    }

    // Debit Card Payment class
    public class DebitCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Debit Card payment of {amount} processed.");
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Debit Card refund of {amount} processed.");
        }

        public bool MakePayment(double amount)
        {
            ProcessPayment(amount);
            return true;
        }
    }

    // Step 4: Order class implementing IPayment
    public class Order : IPayment
    {
        public int OrderId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Location ShippingLocation { get; set; }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Order {OrderId}: Payment of {amount} processed.");
            OrderStatus = OrderStatus.Processing;
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Order {OrderId}: Refund of {amount} processed.");
            OrderStatus = OrderStatus.Cancelled;
        }

        public bool MakePayment(double amount)
        {
            ProcessPayment(amount);
            return true;
        }
    }

    // Program entry point.
    class Program
    {
        static void Main(string[] args)
        {
            // Create location
            Location location = new Location(12.9716, 77.5946);

            // Create order
            Order order = new Order
            {
                OrderId = 101,
                OrderStatus = OrderStatus.Pending,
                ShippingLocation = location
            };

            // Make payment
            order.MakePayment(500.00);

            // Display order details
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine($"Order Status: {order.OrderStatus}");
            Console.WriteLine($"Shipping Location: {order.ShippingLocation.Latitude}, {order.ShippingLocation.Longitude}");
        }
    }
}
