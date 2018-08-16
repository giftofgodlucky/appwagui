using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

namespace WaguiApp
{
	public partial class MainPage : ContentPage
	{
        private LoginPage _loginPopup;
        public MainPage()
		{
			InitializeComponent();
            _loginPopup = new LoginPage();
        }
        private async void OnOpenPupup(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(_loginPopup);
        }
    }
}
