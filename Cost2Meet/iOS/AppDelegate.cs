
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using Xamarin;
using SQLite.Net.Platform.XamarinIOS;

namespace Cost2Meet.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Insights.Initialize(App.InsightsKey);

			Forms.Init ();

			window = new UIWindow (UIScreen.MainScreen.Bounds);

			string dbPath = DatabaseFilePathRetriever.Get(App.DatabaseName);


			window.RootViewController = App.GetMainPage (new SQLitePlatformIOS(), dbPath).CreateViewController ();
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

