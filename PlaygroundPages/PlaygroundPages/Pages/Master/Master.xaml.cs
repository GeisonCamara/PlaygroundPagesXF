using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaygroundPages.Pages.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoToPage1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navigation.FirstPage());
            IsPresented = false;
        }

        private void GoToPage2(object sender, EventArgs args)
        {
            Detail = new Navigation.SecoundPage();
            IsPresented = false;
        }
        private void GoToPage3(object sender, EventArgs args)
        {
            Detail = new Detail();
            IsPresented = false;
        }
    }
}