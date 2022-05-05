using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Terceiro.Tecnico3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ET3 : ContentPage
    {
        public ET3()
        {
            InitializeComponent();
        }

        private async void Web3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT3.Web3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void QT3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT3.Qualidade3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void TCC3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT3.TCC3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Net3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT3.Internet3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Mob3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT3.Mobile3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}