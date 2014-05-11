using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ScrumHelper.Droid
{
    [Activity(Label = "EditProject")]            
    public class EditProjectActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.EditProject);
        }

        protected override void OnResume()
        {
            base.OnResume ();

        }
    }
}

