using System;
using Xamarin.Forms;

namespace XAMARIN_GENERATE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MostrarCV();
        }

        private void MostrarCV()
        {
            string nombre = "José";
            string apellido = "Cuadros";
            string email = "josefrances06@gmail.com";
            string universidad = "San Pablo";
            string carrera = "Ciencia de la Computación";
            string telefono = "934887689";

            CVStackLayout.Children.Clear();

            CVStackLayout.Children.Add(new Label
            {
                Text = "Curriculum Vitae",
                Style = (Style)Resources["TitleLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Nombre: {nombre}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Apellido: {apellido}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Email: {email}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Universidad: {universidad}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Carrera: {carrera}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Teléfono: {telefono}",
                Style = (Style)Resources["CVLabelStyle"]
            });
        }
    }
}
