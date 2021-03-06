﻿using System;
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
    [Activity(Label = "ActionProject")]            
    public class ActionProjectActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ActionProject);
            Button StartMeetingButton = FindViewById<Button>(Resource.Id.StartMeetingButton);
            Button ViewListProjectsButton = FindViewById<Button>(Resource.Id.ViewListProjectsButton);
            Button ViewListPersonsProjectButton = FindViewById<Button>(Resource.Id.ViewListPersonsProjectButton);
            ViewListProjectsButton.Click += delegate
            {
                //SetContentView (Resource.Layout.EditProject);
                //StartActivity(typeof(EditProjectActivity));
                Finish();
                StartActivity(typeof(MainActivity));
            };
            StartMeetingButton.Click += delegate
            {
                //SetContentView (Resource.Layout.EditProject);
                //StartActivity(typeof(EditProjectActivity));
                Finish();
                //StartActivity(typeof(MainActivity));
            };
            ViewListPersonsProjectButton.Click += delegate
            {
                //SetContentView (Resource.Layout.EditProject);
                Finish();
                StartActivity(typeof(PersonProjectActivity));

                //StartActivity(typeof(MainActivity));
            };

        }
    }
}

