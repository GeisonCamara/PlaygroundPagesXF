using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaygroundPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new PlaygroundPages.Pages.Carousel.CarouselView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
