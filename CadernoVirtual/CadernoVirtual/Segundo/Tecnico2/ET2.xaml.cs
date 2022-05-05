using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Segundo.Tecnico2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ET2 : ContentPage
    {
        public ET2()
        {
            InitializeComponent();
        }

        private async void Web2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT2.Web2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void DS2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT2.DS1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void SE2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT2.SE1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Mob2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT2.Mobile2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void BD2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT2.BD2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}