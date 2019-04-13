using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
            
namespace Testability
{

    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            orderProcessor.Process(new Order { DatePlaced = DateTime.Now, TotalPrice = 100f });
        }
    }
}
