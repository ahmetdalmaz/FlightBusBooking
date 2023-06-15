using FlightBusBooking.Business.Abstract;
using FlightBusBooking.DataAccess.Abstract;
using FlightBusBooking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Business.Concrete
{
    public class AirportManager : IAirportService
    {
        private readonly IAirportDal _airportDal;

        public AirportManager(IAirportDal airportDal)
        {
            _airportDal = airportDal;
        }

        public void Add(Airport airport)
        {
            _airportDal.Add(airport);
        }

        public void Delete(Airport airport)
        {
            _airportDal.Delete(airport);
        }

        public Airport GetAirportById(int id)
        {
            return _airportDal.Get(a => a.AirportId==id);
        }

        public List<Airport> GetAirports()
        {
            return _airportDal.GetAll();
        }

        public void Update(Airport airport)
        {
             _airportDal.Update(airport);
        }
    }
}
