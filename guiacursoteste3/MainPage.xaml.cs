namespace guiacursoteste3
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnCardTapped(object sender, EventArgs e)
        {
            if (sender is Frame frame)
            {
                await frame.ScaleTo(1.1, 100);
                await frame.ScaleTo(1.0, 100);

                switch (frame)
                {
                    case var f when f == Card1:
                        await Navigation.PushAsync(new Pagina1());
                        break;
                    case var f when f == Card2:
                        await Navigation.PushAsync(new Pagina2());
                        break;
                    case var f when f == Card3:
                        await Navigation.PushAsync(new Pagina3());
                        break;
                    case var f when f == Card4:
                        await Navigation.PushAsync(new Pagina4());
                        break;
                }
            }
        }

    }

}
