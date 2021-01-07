using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortfolioApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CVPage : ContentPage
    {
        public CVPage()
        {
            InitializeComponent();
        }
        private async void AboutMeNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private async void Back_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void GalleryNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
        }
    }
}