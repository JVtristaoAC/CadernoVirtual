using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CadernoVirtual.Primeiro;
using CadernoVirtual.Segundo;
using CadernoVirtual.Terceiro;
namespace CadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_1ano_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Primeiro._1ano());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro, Tente novamente mais tarde", ex.Message, "OK");
            }
            
  
        }

        private async void btn_2ano_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Segundo._2ano());

            }catch(Exception ex)
            {
                await DisplayAlert("Ocorreu um erro, Tente Novamente mais tarde", ex.Message, "OK");
            }


        }

        private async void btn_3ano_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Terceiro._3ano());

            }catch(Exception ex)
            {
                await DisplayAlert("Ocorreu um erro, Tente novamente mais tarde", ex.Message, "OK");
            }


        }
    }
}
