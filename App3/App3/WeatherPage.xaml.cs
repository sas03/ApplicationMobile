using App3.Models;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherPage : ContentPage
	{
		public WeatherPage ()
		{
			InitializeComponent ();
		}

        public async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            Weather weather = await Services.WeatherService.GetWeather("75002");
            BindingContext = weather;
        }


        public async void ButtonGeoClicked(object sender, EventArgs e)
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
            var longitude = position.Longitude;
            var latitude = position.Latitude;

            Weather weather = await Services.WeatherService.GetWeatherByGeo(latitude, longitude);
            BindingContext = weather;

        }


        public async void BtnAddClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AddCityFavorites(BindingContext as Weather)));
        }

    }
}
