using FlightBusBooking.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Entities.Concrete
{
    public class Country:IEntity
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<City> Cities { get; set; }

    }
}
