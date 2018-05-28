using App3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App3.Services
{
    public class CitiesService
    {
        private static ObservableCollection<City> cities;

        public static ObservableCollection<City> Cities
        {
            get
            {
                if (cities == null)
                    cities = new ObservableCollection<City>();
                return cities;
            }
        }

        public static void Add(City city)
        {
            Cities.Add(city);
        }
    }
}
