using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabService.Model_Layer
{
    public class Cab
    {
        public int CabId { get; set; }
        public string DriverName { get; set; }
        public string LicensePlate { get; set; }
        public bool IsAvailable { get; set; }

        public Cab(int cabId, string driverName, string licensePlate)
        {
            CabId = cabId;
            DriverName = driverName;
            LicensePlate = licensePlate;
            IsAvailable = true; // Initially, the cab is available
        }
    }
}
