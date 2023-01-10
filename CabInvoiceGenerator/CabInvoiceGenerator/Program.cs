using System;
namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL_RIDE);
          
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Fare: " + fare);
        }
    }
}
