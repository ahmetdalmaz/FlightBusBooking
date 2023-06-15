using FlightBusBooking.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Entities.Concrete
{
    public class Airport : IEntity
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public int CityId { get; set; }

        public string IATACode { get; set; }

        public City City { get; set; }

    }
}
