using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using conversores.NewFolder;

namespace conversores
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dolares.Text))
            {
                var pesos = double.Parse(dolares.Text);
                double dolar = pesos * 4087.33;
                Resultado.Text = pesos+" en pesos colombianos es: "+dolar.ToString();
            }
            else
            {
                DisplayAlert("Error", "no tiene valor a convertir", "OK");
            }
        }

        private async void btcolombia_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new convertidor_de_pesos_colombianos());
        }
    }
}
