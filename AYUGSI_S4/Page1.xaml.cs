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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "AYUGSI";
            string contrasena = "123";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contrasena)
            {
                Navigation.PushAsync(new Page2(usuario));

            }
            else {
                DisplayAlert("ERROR","USUARIO Y CONTRASEÑA INCORRECTOS","CERRAR");
            
            }

        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}