using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.Widget;
using HUMobile.Resources;
using Android.Views;
using System.Security.Cryptography.X509Certificates;

namespace HUMobile
{
    [Activity(Label = "HUMobile", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ImageButton cvPlanta, cvOem, cvCons, cvProg;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            cvPlanta = this.FindViewById<ImageButton>(Resource.Id.cvPlanta);
            cvOem = this.FindViewById<ImageButton>(Resource.Id.cvOem);
            cvCons = this.FindViewById<ImageButton>(Resource.Id.cvCons);
            cvProg = this.FindViewById<ImageButton>(Resource.Id.cvProg);



            cvPlanta.Click += (sender, e) =>  {
				var ActivityIntent =
						new Android.Content.Intent(this, typeof(ActivityPlanta));
				StartActivity(ActivityIntent);
            };

            cvOem.Click += (sender, e) => 
            {
                
            };

            cvCons.Click += (sender, e) => 
            {
                
            };

            cvProg.Click += (sender, e) => 
            {
                
            };

        }


		protected override void OnSaveInstanceState(Bundle outState)
		{
			base.OnSaveInstanceState(outState);
		}

		protected override void OnStart()
		{
			base.OnStart();
		}

		protected override void OnResume()
		{
			base.OnResume();
		}

		protected override void OnPause()
		{
			base.OnPause();
		}

		protected override void OnStop()
		{
			base.OnStop();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		protected override void OnRestart()
		{
			base.OnRestart();
		}


    }

}

