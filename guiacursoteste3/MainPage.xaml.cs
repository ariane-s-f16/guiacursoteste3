using UIKit;
using WebKit;

namespace guiacursoteste3
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnCardTapped(object sender, System.EventArgs e)
        {
            var gestureRecognizer = sender as TapGestureRecognizer;
            var cardName = gestureRecognizer?.CommandParameter.ToString(); 
            // Pega o nome do card clicado (Card1, Card2, etc)

            // Verifique qual card foi clicado e navegue para a página desejada
            if (cardName == "Card1")
            {
                // Exemplo: navegar para a página Pag1
                await Navigation.PushAsync(new Pagina1());
            }
            else if (cardName == "Card2")
            {
                // Navegar para outra página, se necessário
                await Navigation.PushAsync(new Pagina2());
            }
            else if (cardName == "Card3")
            {
                // Navegar para outra página, se necessário
                await Navigation.PushAsync(new Pagina3());
            }
            else if (cardName == "Card4")
            {
                // Navegar para outra página, se necessário
                await Navigation.PushAsync(new Pagina3());
            }
        }

    }

}
