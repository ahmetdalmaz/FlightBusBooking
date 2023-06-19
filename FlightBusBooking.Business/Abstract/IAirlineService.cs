using FlightBusBooking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Business.Abstract
{
    public interface IAirlineService
    {
        void Add(Airline airline);
        void Update(Airline airline);
        void Delete(Airline airline);
        List<Airline> GetAirlines();
        Airline GetAirlineById(int id);
    }
}
