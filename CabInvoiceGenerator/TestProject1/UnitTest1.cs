using CabInvoiceGenerator;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Return_TotalFare_ForNormalRide()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL_RIDE);
            double distance = 5.0;
            int time = 10;

            double fare = invoice.CalculateFare(distance, time);
            double expected = 60.0;
            Assert.AreEqual(expected, fare);

        }
        [Test]
        /// <summary>
        /// UC2-Returns the totlfare for multiple rides
        /// </summary>
        
        public void Return_Multiple_Rides_TotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.PREMIUM_RIDE);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = new InvoiceSummary(2, 55.0);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.totalFare, expected.totalFare);
        }
        [Test]
        /// <summary>
        /// UC3-Returns the average ride
        /// </summary>
        
        public void Return_Multiple_Rides_AverageFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.PREMIUM_RIDE);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = new InvoiceSummary(2, 55.0);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.avgFare, expected.avgFare);
        }
        [Test]
        /// <summary>
        /// UC3-returns the number of rides
        /// </summary>

        public void Return_Multiple_Rides_NumofRides()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.PREMIUM_RIDE);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = new InvoiceSummary(2, 55.0);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.numOfRides, expected.numOfRides);
        }

    }
}
    
