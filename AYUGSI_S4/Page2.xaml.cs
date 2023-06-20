using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AYUGSI_S4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string usuario;
        public Page2(string usuario )
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO " +usuario;
            this.usuario = usuario;



        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato =  Convert.ToDouble( txtDato.Text);

                 if ( dato > 100 || dato < 0) 
                {
                    DisplayAlert("ERROR"," FUERA DE RANGO 1 - 100","CERRAR");
                    txtDato.Text = "";
                
                }

            }
            catch (Exception)
            {
                DisplayAlert("ERROR", " ERROR AL EJECUTAR", "CERRAR");
            }

        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtDato.Text);
            string alumno = pkAlumnos.Items[pkAlumnos.SelectedIndex];
            Navigation.PushAsync(new Page3(usuario,dato,alumno));


        }
    }
}