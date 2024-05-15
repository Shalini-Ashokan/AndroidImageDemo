using System.Net.Http;

namespace ImageDemo
{
    public partial class MainPage : ContentPage
    {
        private HttpClient httpClient;
        public MainPage()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            this.LoadImage();
        }

        private async void LoadImage()
        {
            var imageBytes = await httpClient.GetByteArrayAsync("https://dummyimage.com/300x200/000/fff.png");
            MemoryStream cacheStream = new(imageBytes);
            MemoryStream memoryStream = new(imageBytes);
            if (ImageView != null)
            {
                ImageView.Source = ImageSource.FromStream(() => memoryStream);
            }
        }
    }

}
