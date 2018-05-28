using App3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App3.Services
{
    public class WeatherService
    {

        const string url = "";
        const string key = "72d193a05791f86be81e1f0c49e123d2";
        /*
        public static async Task<Weather> GetWeather(string zipCode)
        //public static async Task<Weather> GetWeather(string city)
        { 
            string queryString = $"{url}?zip={zipCode},fr&appid={key}&units=metric";

            //string queryString = $"{url}?q=(city),fr&appid=(key)&units=metric";
           ☺

            var results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);

            if (results != null)
            {
                Weather weather = new Weather();

                weather.City = results["name"];
                weather.Temperature = results["main"]["temp"]+" °C";
                weather.Wind = results["wind"]["speed"];
                weather.Humidity = results["main"]["humidity"]+" %";
                weather.Visibility = results["visibility"];

                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);


                weather.Sunrise = sunrise.ToString("HH:mm:ss") + " UTC";
                weather.Sunset = sunrise.ToString("HH:mm:ss") + " UTC";

                return weather;
            }
                return null;

        } */ 


        public static async Task<Weather> GetWeatherByGeo(double lat, double lon)
        {

           // string queryString = $"{url}?zip={zipCde},fr&appid={key}&units=metric";
           string queryString = $"{url}?lat={lat.ToString()}&lon={lon.ToString()},fr&appid={key}&units=metric";
           var results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);

            if (results != null)
            {
                Weather weather = new Weather();

                weather.City = results["name"];
                weather.Temperature = results["main"]["temp"] + " °C";
                weather.Wind = results["wind"]["speed"];
                weather.Humidity = results["main"]["humidity"] + " %";
                weather.Visibility = results["visibility"];

                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);


                weather.Sun.Sunrise = sunrise.ToString("HH:mm:ss") + " UTC";
                weather.Sun.Sunset = sunrise.ToString("HH:mm:ss") + " UTC";
                

                return weather;
            }
            return null;
        }
        /*
       private static async GetData( string queryString)
        {

        }*/
        public static async Task<Weather> GetWeather(string zipCode)
        {
            string key = "72d193a05791f86be81e1f0c49e123d2";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip="
                + zipCode + ",fr&appid=" + key + "&units=metrics";

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(true);

            if (results != null)
            {
                Weather weather = new Weather();

                weather.City = results["name"];
                weather.Temperature = results["main"]["temp"] + " °C";
                weather.Wind = results["wind"]["speed"];
                weather.Humidity = results["main"]["humidity"] + " %";
                weather.Visibility = results["visibility"];

                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);


                weather.Sun.Sunrise = sunrise.ToString("HH:mm:ss") + " UTC";
                weather.Sun.Sunset = sunrise.ToString("HH:mm:ss") + " UTC";

                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}
