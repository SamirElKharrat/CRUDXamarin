using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRUDXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void btnRegistrar(object sender, EventArgs e)
        {
            if (true)
            {

            }
            else
            {
                await DisplayAlert("Error", "Ingresar todos los datos", "OK");
            }
        }

        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtNombre.Text()))
            {

            }
            return respuesta;
        }
    }
}
