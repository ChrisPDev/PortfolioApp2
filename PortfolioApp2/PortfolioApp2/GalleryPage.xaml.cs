using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortfolioApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        readonly ObservableCollection<GalleryBindings> gallery = new ObservableCollection<GalleryBindings>();
        public ObservableCollection<GalleryBindings> Gallery { get { return gallery; } }
        public GalleryPage()
        {
            InitializeComponent();

            GalleryView.ItemsSource = gallery;

            gallery.Add(new GalleryBindings { Image = "Christoffer.jpg", Title = "Profil billede", Description = "Dette er mit profil billede, er jeg ikke flot." });
            gallery.Add(new GalleryBindings { Image = "RedRingHood.jpeg", Title = "Standard baggrunden", Description = "Bruger dette billede som baggrund på alt jeg kan sætte det på." });
            gallery.Add(new GalleryBindings { Image = "tenor.gif", Title = "Fantastisk gif", Description = "Denne gif er smuk og skal selvfølgelig også med i denne app." });
        }

        private async void AboutMeNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private async void Back_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void CVNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CVPage());
        }
    }
}