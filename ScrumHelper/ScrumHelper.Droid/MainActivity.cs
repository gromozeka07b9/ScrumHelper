using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ScrumHelper.BL;
using System.Collections.Generic;

namespace ScrumHelper.Droid
{
	[Activity (Label = "ScrumHelper.Droid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
				Project prj = new Project(){Name = "test1"};
				ScrumHelper.BL.Managers.ProjectManager.SaveProject(prj);
				var result = ScrumHelper.BL.Managers.ProjectManager.DeleteProject(prj.ID);
			};

			var prj1 = ScrumHelper.BL.Managers.ProjectManager.GetProjects ();
			ListView lv = FindViewById<ListView> (Resource.Id.listView1);
			string[] items = new string[]{ "test", "test2" };
			JavaList items2 = new JavaList();
			foreach (var item in prj1) 
			{
				//items.Add (item.Name);
			}
			lv.Adapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, items);
			//lv.Adapter = ListAdapter;
		}
		protected override void OnResume()
		{
			base.OnResume ();

		}
	}
}


