using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCityFavorites : ContentPage
    {
        public AddCityFavorites(Weather weather)
        {
            InitializeComponent();
            BindingContext = weather;
        }

        public async void BtnSaveClicked(object sender, EventArgs e)
        {
            var weather = BindingContext as Weather;
            var city = new City();
            city.Latitude = weather.Latitude;
            city.Longitude = weather.Longitude;
            city.Name = weather.Title;
            Services.CitiesService.Add(city);
            await Navigation.PopModalAsync();
        }

    }
}
