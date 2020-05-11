using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSyncfusionCsla.ViewModels;

namespace XamarinSyncfusionCsla
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel vm;

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = vm = new LoginViewModel();
            vm.Model.SuppressRuleChecking();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {

        }

        private void GoogleLogin_Clicked(object sender, EventArgs e)
        {

        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            vm.Model.ContinueRuleChecking();
        }
    }
}
