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
            //Dentro de um botão definido como assincrono colocamos um try catch caso ocorra algum erro na navegação 
            try
            {
                await Navigation.PushAsync(new Primeiro._1ano());
                // Esperando a resposta do usuario ele coloca a página 1ano que se encontra na pasta Primeiro em cima da
                // Pagina atual
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro, Tente novamente mais tarde", ex.Message, "OK");
                //Cria um alerta caso ocorra algum erro entre a navegação
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
