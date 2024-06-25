using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formulario_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurriculumPage : ContentPage
    {
        public CurriculumPage(string nombre, string apellido, string estudios, string experiencia, string area, string telefono, string correo)
        {
            InitializeComponent();
            nombreLabel.Text += nombre;
            apellidoLabel.Text += apellido;
            estudiosLabel.Text += estudios;
            experienciaLabel.Text += experiencia + " años de experiencia";
            areaLabel.Text += area;
            telefonoLabel.Text += telefono;
            correoLabel.Text += correo;
        }
    }
}
