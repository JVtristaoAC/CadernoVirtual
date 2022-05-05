using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Segundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _2ano : ContentPage
    {
        public _2ano()
        {
            InitializeComponent();
        }

        private async void btnEM2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Medio2.EM2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void btnET2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Tecnico2.ET2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}