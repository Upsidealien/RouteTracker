using Foundation;
using UIKit;
using Xamarin.Forms;
using System;
using FormsBackgrounding.Messages;

namespace FormsBackgrounding.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{

		#region Methods
		iOSLongRunningTaskExample longRunningTaskExample;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();

			LoadApplication (new App ());

			WireUpLongRunningTask ();

			return base.FinishedLaunching (app, options);
		}

		void WireUpLongRunningTask ()
		{
			MessagingCenter.Subscribe<StartLongRunningTaskMessage> (this, "StartLongRunningTaskMessage", async message => {
				longRunningTaskExample = new iOSLongRunningTaskExample ();
				await longRunningTaskExample.Start ();
			});

			MessagingCenter.Subscribe<StopLongRunningTaskMessage> (this, "StopLongRunningTaskMessage", message => {
				longRunningTaskExample.Stop ();
			});
		}
		#endregion
	}
}