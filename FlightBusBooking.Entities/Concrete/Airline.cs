using FlightBusBooking.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Entities.Concrete
{
    public class Airline: IEntity
    {
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public int AirlineCode { get; set; }
    }
}
