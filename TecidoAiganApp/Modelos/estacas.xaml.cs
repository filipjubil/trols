using System;
using Xamarin.Forms;

namespace SeuProjeto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Produtos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProdutosPage());
        }

       

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PopAsync();
        }
    }
}