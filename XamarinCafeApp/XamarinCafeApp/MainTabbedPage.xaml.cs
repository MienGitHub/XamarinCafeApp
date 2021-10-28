using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCafeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void espressoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }

        private async void hotdrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksPage());
        }

        private async void colddrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinksPage());
        }
        private async void quickbitesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBitesPage());
        }
    }
}