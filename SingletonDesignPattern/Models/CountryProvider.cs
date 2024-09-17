using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Models
{
    public class CountryProvider
    {
        private static CountryProvider instance = null;

        public static CountryProvider Instance
        {
            get
            {
               instance = instance ?? (instance = new CountryProvider());
               return instance;
            }
        }

        private new List<Country> Countries {  get; set; }

        private CountryProvider()
        {
                Task.Delay(2000).GetAwaiter().GetResult();

            Countries =  new List<Country>()
            {
                new Country(){Name = "Azerbaijan"},
                new Country(){Name = "Turkiye"}
            };

        }


        public async Task<List<Country>> GetCountries() => Countries;
    }
}
