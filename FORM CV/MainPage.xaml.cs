using System;
using Xamarin.Forms;

namespace Formulario_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCreateCvButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CurriculumPage(nombre.Text, apellido.Text, estudios.Text, experiencia.Text, area.Text, telefono.Text, correo.Text));
        }
    }
}
