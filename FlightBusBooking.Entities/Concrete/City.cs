using FlightBusBooking.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Entities.Concrete
{
    public class City : IEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }

        public int CountryId { get; set; }

        public List<District> Districts { get; set; }
        public Country Country { get; set; }
        // public List<Airport> Airports { get; set; }

    }
}
