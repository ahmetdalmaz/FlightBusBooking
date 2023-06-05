using FlightBusBooking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.Business.Abstract
{
    public interface ICountryService
    {
        void Add(Country country);
        void Update(Country country);
        void Delete(Country country);
        List<Country> GetCountries();
        Country GetCountryById(int id);



    }
}
