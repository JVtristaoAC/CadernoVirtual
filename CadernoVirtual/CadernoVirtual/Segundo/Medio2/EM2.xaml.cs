using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Segundo.Medio2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EM2 : ContentPage
    {
        public EM2()
        {
            InitializeComponent();
        }

        private async void Port2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Portugues2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Mat2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Matematica());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Filo2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Filosofia2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Bio2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Biologia2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Geo2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Geografia2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void His2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Historia2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Qui2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Quimica2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void EdFis2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Ed_Fisica2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Fis2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Fisica2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void ing2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Ingles2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Etica2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Etica2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Socio2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM2.Sociologia2());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}