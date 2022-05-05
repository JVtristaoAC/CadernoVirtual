using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Primeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _1ano : ContentPage
    {
        public _1ano()
        {
            InitializeComponent();
        }

        private async void btnEM1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Medio1.EM1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void btnET1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Tecnico1.ET1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}