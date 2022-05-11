using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace conversores.NewFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class convertidor_de_pesos_colombianos : ContentPage
    {
        public convertidor_de_pesos_colombianos()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PesosColombianos.Text))
            {
                var pesos = double.Parse(PesosColombianos.Text);
                double dolares = pesos * 0.00025;
                Dolares.Text = pesos + " en dolares es: " + dolares.ToString();
            }
            else
            {
                DisplayAlert("Error", "no tiene valor a convertir", "OK");
            }
        }

        private void btdolar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}