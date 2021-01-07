using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PortfolioApp2
{
    public partial class MainPage : ContentPage
    {
        readonly ObservableCollection<ProfileBindings> profile = new ObservableCollection<ProfileBindings>();
        public ObservableCollection<ProfileBindings> Profile { get { return profile; } }
        public MainPage()
        {
            InitializeComponent();

            ProfileView.ItemsSource = profile;

            profile.Add(new ProfileBindings{ ProfileImage = "Christoffer.jpg", ProfileName = "Christoffer Petersen", ProfileLocation = "Viborg - Danmark", FullName = "Christoffer Møller Petersen", Age = "28", Phone = "+45 61 68 45 28", StreetAdress = "Bellisvej 10 St Th", City = "8800 - Viborg", Email = "cmpe.skpedu.mercantec.dk" });
        }
        private async void AboutMeNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private async void CVNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CVPage());
        }
        private async void GalleryNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
        }
    }
}
