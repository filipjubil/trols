using Microsoft.Maui.Controls;

namespace TecidoAiganApp
{
    public partial class ProdutosPage : ContentPage
    {
        public ProdutosPage()
        {
            InitializeComponent();
        }

        private async void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Adicione a lógica de confirmação aqui
            await DisplayAlert("Confirmado", "Produto confirmado com sucesso!", "OK");
        }

        private async void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Adicione a lógica de cancelamento aqui
            await DisplayAlert("Cancelado", "Operação cancelada.", "OK");
        }
    }
}
