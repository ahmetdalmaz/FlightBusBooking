using FlightBusBooking.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Entities.Concrete
{
    public class District:IEntity
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }

    }
}
