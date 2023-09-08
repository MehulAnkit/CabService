using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabService.Model_Layer
{
    public class Ride
    {
        public int RideId { get; set; }
        public Cab Cab { get; set; }
        public Passenger Passenger { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; } // Nullable to represent ongoing rides
        public double Fare { get; set; }

        // Constructor that takes Cab and Passenger as arguments
        public Ride(int rideId, Cab cab, Passenger passenger)
        {
            RideId = rideId;
            Cab = cab;
            Passenger = passenger;
            StartTime = DateTime.Now;
        }
    }
}
