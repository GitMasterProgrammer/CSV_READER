using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class City
    {
        public string cityName = "";
        public string cityCode = "";
        public string country = "";

        public uint totalPopulation = 0;
        public uint womanPopulation = 0;
        public uint menPopulation = 0;

        public City(string cityName, string cityCode)
        {
            this.cityName = cityName;
            this.cityCode = cityCode;
        }

        public City(string _cityName, string _cityCode, string _country, uint _totalPopulation, uint _womanPopulation, uint _menPopulation) {
            cityName = _cityName;
            cityCode = _cityCode;
            country = _country;
            totalPopulation = _totalPopulation;
            womanPopulation= _womanPopulation;
            menPopulation = _menPopulation;
        }
    }
}
