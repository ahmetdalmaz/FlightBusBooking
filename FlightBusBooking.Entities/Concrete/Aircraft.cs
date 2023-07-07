using FlightBusBooking.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Entities.Concrete
{
    public class Aircraft : IEntity
    {
        public int AircraftId { get; set; }
        public int AirlineId { get; set; }
        public string AircraftModel { get; set; }
        public int Capacity { get; set; }
    }
}
