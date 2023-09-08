using CabService.Model_Layer;
using CabService.View;

namespace CabService
{
    internal class Program
    {
        static void Main()
        {
            Controller.CabService cabService = new Controller.CabService();
            ConsoleView view = new ConsoleView();

            // Add some cabs
            cabService.AddCab(new Cab(1, "John Doe", "ABC123"));
            cabService.AddCab(new Cab(2, "Jane Smith", "XYZ789"));

            // Request a ride
            Passenger passenger = new Passenger(1, "Alice");
            cabService.RequestRide(passenger);

            // Simulate ride completion (you can end the ride with the ride ID)
            cabService.EndRide(1);
        }
    }
}
