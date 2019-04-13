using System;

namespace Testability
{

    public class Order
    {
        public DateTime DatePlaced;
        public float TotalPrice;
        public bool IsShipped;
        public Shipment Shipment;
    }
}