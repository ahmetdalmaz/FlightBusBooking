using FlightBusBooking.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Entities.Concrete
{
    public class CabinClasses: IEntity
    {
        public int CabinClassId { get; set; }
        public string? CabinClassName { get; set; }
    }
}
