using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    [TestClass]
    public class ProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_IsShipped_ThrowException()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            orderProcessor.Process(new Order { IsShipped = true, Shipment = new Shipment() });
        }

        public class MockShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 100f;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_Mock_IsShipped_ThrowException()
        {
            var orderProcessor = new OrderProcessor(new MockShippingCalculator());
            orderProcessor.Process(new Order { IsShipped = true, Shipment = new Shipment() });
        }

        [TestMethod]
        public void Process_Mock_IsNotShipped_SetShipment()
        {
            var orderProcessor = new OrderProcessor(new MockShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(100f, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }
}
