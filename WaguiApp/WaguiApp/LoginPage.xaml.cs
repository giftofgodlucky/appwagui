using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaguiApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : PopupPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
	}
}