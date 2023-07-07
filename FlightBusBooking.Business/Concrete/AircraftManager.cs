using FlightBusBooking.Business.Abstract;
using FlightBusBooking.DataAccess.Abstract;
using FlightBusBooking.DataAccess.Concrete.EntityFramework;
using FlightBusBooking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Business.Concrete
{
    public class AircraftManager : IAircraftService
    {
        private readonly IAircraftDal _aircraftDal;

        public AircraftManager(IAircraftDal aircraftDal)
        {
            _aircraftDal = aircraftDal;
        }

        public void Add(Aircraft aircraft)
        {
            _aircraftDal.Add(aircraft);
        }

        public void Delete(Aircraft aircraft)
        {
            _aircraftDal.Delete(aircraft);
        }

        public Aircraft GetAircraftById(int id)
        {
           return _aircraftDal.Get(a => a.AircraftId == id);
        }

        public List<Aircraft> GetAircrafts()
        {
            return _aircraftDal.GetAll();
        }

        public void Update(Aircraft aircraft)
        {
            _aircraftDal.Update(aircraft);
        }
    }
}
