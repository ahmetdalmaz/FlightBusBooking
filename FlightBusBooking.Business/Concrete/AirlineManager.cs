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
    public class AirlineManager : IAirlineService
    {
        private readonly IAirlineDal _airlineDal;

        public AirlineManager(IAirlineDal airlineDal)
        {
            _airlineDal = airlineDal;
        }

        public void Add(Airline airline)
        {
            _airlineDal.Add(airline);
        }

        public void Delete(Airline airline)
        {
            _airlineDal.Delete(airline);
        }

        public List<Airline> GetAirlines()
        {
            return _airlineDal.GetAll();
        }

        public Airline GetAirlineById(int id)
        {
            return _airlineDal.Get(a => a.AirlineId == id);
        }

        public void Update(Airline airline)
        {
            _airlineDal.Update(airline);
        }
    }
}
