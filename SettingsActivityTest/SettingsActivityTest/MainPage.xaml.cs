using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SettingsActivityTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnOpenWifiSettings.Clicked += BtnOpenWifiSettings_Clicked;
		}

        private async void BtnOpenWifiSettings_Clicked(object sender, EventArgs e)
        {
            IAppService appService = DependencyService.Get<IAppService>();
            await appService.OpenWifiSettings();
        }
    }
}
