using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Terceiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _3ano : ContentPage
    {
        public _3ano()
        {
            InitializeComponent();
        }

        private async void btnEM3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Medio3.EM3());

            }catch(Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void btnET3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Tecnico3.ET3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}