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
    public class CabinClassesManager : ICabineClassesService
    {
        private readonly ICabinClassesDal _cabinClassesDal;
        public CabinClassesManager(ICabinClassesDal cabinClassesDal)
        {
            _cabinClassesDal = cabinClassesDal;
        }

        public void Add(CabinClasses cabinClasses)
        {
            _cabinClassesDal.Add(cabinClasses);
        }

        public void Delete(CabinClasses cabinClasses)
        {
            _cabinClassesDal.Delete(cabinClasses);
        }

        public CabinClasses GetCabinClassById(int id)
        {
            return _cabinClassesDal.Get(c => c.CabinClassId == id);
        }

        public List<CabinClasses> GetCabinClasses()
        {
            return _cabinClassesDal.GetAll();
        }

        public void Update(CabinClasses cabinClasses)
        {
            _cabinClassesDal.Update(cabinClasses);
        }
    }
}
