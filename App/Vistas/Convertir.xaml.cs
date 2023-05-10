using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;  

namespace App.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        
        double euros;
        double pesetas;
        public Convertir()
        {
            InitializeComponent();
        }

        private void calcular()
        {
            euros = Convert.ToDouble( txteuros.Text);
            pesetas = euros / 166.386;
            lblresultado.Text = pesetas.ToString() + " eur";
        }

        private void validar()
        {
            if(!string.IsNullOrEmpty(txteuros.Text))
            {
                calcular();
            }
            else { DisplayAlert("Error", "No has puesto cantidad!!" , "Intentar de nuevo"); }
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}