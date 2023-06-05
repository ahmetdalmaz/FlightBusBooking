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
    public class CountryManager : ICountryService
    {
        private readonly ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public void Add(Country country)
        {
            _countryDal.Add(country);
            
        }

        public void Delete(Country country)
        {
            _countryDal.Delete(country);
        }

        public List<Country> GetCountries()
        {
            return _countryDal.GetAll();
        }

        public Country GetCountryById(int id)
        {
            return _countryDal.Get(c=>c.CountryId == id);
        }

        public void Update(Country country)
        {
            _countryDal.Update(country);
        }
    }
}
