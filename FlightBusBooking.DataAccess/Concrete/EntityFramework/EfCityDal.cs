using FlightBusBooking.DataAccess.Abstract;
using FlightBusBooking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal: EfEntityRepositoryBase<City, FlightBusBookingContext>, ICityDal
    {

    }
}
