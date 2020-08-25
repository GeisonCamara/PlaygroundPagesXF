using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaygroundPages.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void OpenSecoundPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new SecoundPage());
        }

        private void OpenModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void OpenMasterDetail(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}