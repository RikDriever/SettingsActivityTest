using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using SettingsActivityTest.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidAppService))]
namespace SettingsActivityTest.Droid
{
    public class AndroidAppService : IAppService
    {
        Context CurrentContext => CrossCurrentActivity.Current.Activity;

        public Task OpenWifiSettings()
        {
            Intent intent = new Intent("android.intent.action.MAIN");
            intent.SetComponent(ComponentName.UnflattenFromString("com.android.settings/.wifi.WifiSettings"));
            intent.AddCategory("android.intent.category.DEFAULT");

            return Task.Run(() =>
            {
                try
                {
                    CurrentContext.StartActivity(intent);
                }
                catch (Exception)
                {
                    Toast.MakeText(CurrentContext.ApplicationContext, "Unable to open Wifi Settings", ToastLength.Short);
                }
            });

        }
    }
}