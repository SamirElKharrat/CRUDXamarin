using CRUDXamarin.Models;
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
            if (validarDatos())
            {
                Alumno alum = new Alumno
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    SegundoApellido = txtSecApellido.Text,
                    Edad = int.Parse(txtEdad.Text),
                    Email = txtEmail.Text,
                };
                await App.SQLiteDB.GuardarAlumnoAsync(alum);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtSecApellido.Text = "";
                txtEdad.Text = "";
                txtEmail.Text = "";
                await DisplayAlert("Registro", "Se registro de manera exitosa", "OK");
                var alumnoList = await App.SQLiteDB.MostrarAlumnosAsync();
                if (alumnoList != null)
                {
                    lstAlumnos.ItemsSource = alumnoList;
                }
            }
            else
            {
                await DisplayAlert("Error", "Ingresar todos los datos", "OK");
            }
        }

        public bool validarDatos()
        {
            bool respuesta = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtSecApellido.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEdad.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
