using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DivisasApp2022.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversorView : ContentPage
    {
        const double tasa = 19.11;

        public ConversorView()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            PesosEntry.Text = string.Empty;
            DolaresLabel.Text = string.Empty;
        }

        private async void ConversorButton_Clicked(object sender, EventArgs e)
        {
            double pesos = 0, dolares = 0;

            if (double.TryParse(PesosEntry.Text, out pesos))
            {
                dolares = pesos / tasa;
                DolaresLabel.Text = $"{dolares:N2}";
            }
            else
            {
                await DisplayAlert("Error", "Cantidad no válida", "OK");
                Limpiar();
            }
        }

        private void LimpiarButton_Clicked(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}