using FlightBusBooking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Business.Abstract
{
    public interface ICabineClassesService
    {
        void Add(CabinClasses cabinClasses);
        void Delete(CabinClasses cabinClasses);
        void Update(CabinClasses cabinClasses);

        List<CabinClasses> GetCabinClasses();

        CabinClasses GetCabinClassById(int id);

    }
}
