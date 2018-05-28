using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class Weather
    {    
        public string Title { get; set; } = " ";
        public string City { get; set; } = " ";
        public string Temperature { get; set; } = " ";
        public string Wind { get; set; } = " ";
        public string Humidity { get; set; } = " ";
        public string Icon { get; set; }
        //public string Sunrise { get; set; } = " ";
        public string Visibility { get; set; } = " ";
        public Sun Sun { get; set; } = new Sun();
        public string Longitude { get; set; } = "";
        public string Latitude { get; set; } = "";
    }

    public class Sun
    {
        public string Sunrise { get; set; } = " ";
        public string Sunset { get; set; } = " ";
    }
}
