using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadernoVirtual.Terceiro.Medio3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EM3 : ContentPage
    {
        public EM3()
        {
            InitializeComponent();
        }

        private async void EdFis3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Ed_Fisica());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Fis3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Fisica3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void ing3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Ingles3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Port3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Portugues());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Mat3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Matematica3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Filo3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Filosofia3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }


        private async void Bio3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Biologia3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Geo3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Geografia3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void His3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Historia3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }

        private async void Qui3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MateriasM3.Quimica3());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Deu erro :/", ex.Message, "OK");
            }
        }
    }
}