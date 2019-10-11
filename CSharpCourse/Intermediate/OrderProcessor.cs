using System;
namespace CSharpCourse.Intermediate
{
    public class OrderProcessor
    {
        public readonly ShippingCalculator shippingCalculator;

        public OrderProcessor()
        {
            shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("this order is already proessed");

            order.Shipment = new Shipment
            {
                Cost = shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        } 
    }
}

// Interfaces and how it improve testebility and extensibility of application
// interface is a language construct that is similar to a class(in terms of syntax) but is fundamentally different.
// interface don not have implementation eg - public interface ICalculate{ int calculate(); }
// interface members doesn't have access modifiers.
// interface used to build lossely coupled applications.