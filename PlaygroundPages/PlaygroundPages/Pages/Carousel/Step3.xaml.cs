using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaygroundPages.Pages.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step3 : ContentPage
    {
        public Step3()
        {
            InitializeComponent();
        }

        private void GoToFirstPage(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.FirstPage());
            App.Current.MainPage = new Tabbed.Tabs();
        }
    }
}