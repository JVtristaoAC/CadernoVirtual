using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Primeiro.Tecnico1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ET1 : ContentPage
    {
        public ET1()
        {
            InitializeComponent();
        }

        private async void Web1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT1.Web1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Anal1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT1.Analise1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void design1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT1.Design1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Fund1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT1.Fundamentos1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Pro1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT1.Programacao1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void BD1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasT1.BD1());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}