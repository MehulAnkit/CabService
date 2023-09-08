using CabService.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabService.Controller
{
    // Define a class for the CabService
    public class CabService
    {
        private List<Cab> cabs;
        private List<Ride> rides;
        private int rideCounter;

        public CabService()
        {
            cabs = new List<Cab>();
            rides = new List<Ride>();
            rideCounter = 1;
        }

        public void AddCab(Cab cab)
        {
            cabs.Add(cab);
        }

        public void RequestRide(Passenger passenger)
        {
            // Find an available cab
            Cab availableCab = cabs.Find(cab => cab.IsAvailable);
            if (availableCab == null)
            {
                Console.WriteLine("No available cabs at the moment. Please try again later.");
                return;
            }

            // Assign the cab to the passenger and mark it as unavailable
            availableCab.IsAvailable = false;

            // Create a new ride
            Ride ride = new Ride(rideCounter++, availableCab, passenger);

            // Add the ride to the list of rides
            rides.Add(ride);

            Console.WriteLine($"Ride requested by {passenger.Name}. Cab {availableCab.CabId} is on its way.");
        }

        public void EndRide(int rideId)
        {
            // Find the ride by its ID
            Ride ride = rides.Find(r => r.RideId == rideId);
            if (ride == null)
            {
                Console.WriteLine("Ride not found.");
                return;
            }

            // Calculate the fare (simplified calculation for demonstration)
            TimeSpan duration = DateTime.Now - ride.StartTime;
            double fare = duration.TotalMinutes * 0.1; // Rs. 0.10 per minute
            ride.Fare = fare;

            // Mark the cab as available
            ride.Cab.IsAvailable = true;

            // Set the end time
            ride.EndTime = DateTime.Now;

            Console.WriteLine($"Ride completed. Fare: ${fare:F2}");
        }
    }
}
