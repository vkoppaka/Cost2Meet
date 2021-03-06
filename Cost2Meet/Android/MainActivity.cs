﻿
using Android.App;
using Android.Content.PM;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin;
using SQLite.Net.Platform.XamarinAndroid;


namespace Cost2Meet.Android
{
	[Activity (Label = "Cost2Meet.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Insights.Initialize (App.InsightsKey, this);


			Xamarin.Forms.Forms.Init (this, bundle);

			string dbPath = DatabaseFilePathRetriever.Get(App.DatabaseName);


			SetPage (App.GetMainPage (new SQLitePlatformAndroid(), dbPath));
		}
	}
}

