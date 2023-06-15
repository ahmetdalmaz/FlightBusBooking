using FlightBusBooking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Business.Abstract
{
    public interface IAirportService
    {
        void Add(Airport airport);
        void Update(Airport airport);
        void Delete(Airport airport);
        List<Airport> GetAirports();
        Airport GetAirportById(int id);
    }
}
