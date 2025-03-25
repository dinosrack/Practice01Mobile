using System.Net.Http.Json;

namespace ProdPracticeMobile
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var marketOffers = await _httpClient.GetFromJsonAsync<List<MarketOffers>>("https://localhost:44380/api/MarketOffers");
                if (marketOffers != null)
                {
                    collectionView.ItemsSource = marketOffers;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", ex.Message, "OK");
            }
        }
    }
}