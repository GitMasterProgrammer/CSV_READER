using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Program
{
    internal class CSVReader
    {
        private string? filePath;

        public CSVReader(string _filePath)
        {
            filePath = _filePath;
        }

        public City[]? ReadFirstNCities(uint nCities)
        {
            City[] cities = new City[nCities];
            StreamReader streamReader = new StreamReader(filePath);
            for (int i = 0; i < nCities; i++)
            {
                string line = streamReader.ReadLine();
                City city = readCityFromCsvLine(line);
                cities[i] = city;
            }
            streamReader.Close();
            return cities;
        }

        public City readCityFromCsvLine(string line) {
            string[] parts = line.Split(',');
            string cityName = parts[0];
            string cityCode = parts[1];


            return new City(cityName, cityCode);
        }
    }
}
