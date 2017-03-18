using Xamarin.Forms;
using System;

namespace FormsBackgrounding
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new LongRunningPage();
		}

		protected override void OnStart ()
		{
		}

		protected override void OnSleep ()
		{
		}

		protected override void OnResume ()
		{
		}
			
	}
}