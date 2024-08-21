using System.Collections.Generic;
using Xamarin.Forms;

namespace SeuProjeto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Entrar_Clicked(object sender, EventArgs e)
        {
            

            
            string usuario =
            string senha = 

            if (usuario == "admin" && senha == "123")
            {
                await Navigation.PushAsync(new PaginaPrincipal());
            }
            else
            {
                await DisplayAlert("Erro", "Usuário ou senha inválidos.", "OK");
            }
        }
    }
}