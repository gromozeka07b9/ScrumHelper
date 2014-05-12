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
using ScrumHelper.BL;

namespace ScrumHelper.Droid
{
    [Activity(Label = "EditProject")]            
    public class EditProjectActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EditProject);

            Button AcceptButton = FindViewById<Button>(Resource.Id.AcceptButton);
            Button CancelButton = FindViewById<Button>(Resource.Id.CancelButton);
            AcceptButton.Click += delegate
            {
                EditText NameProjectEditText = FindViewById<EditText>(Resource.Id.NameProjectEditText);
                EditText DescriptionProjectEditText = FindViewById<EditText>(Resource.Id.DescriptionProjectEditText);
                Project NewItemProject = new Project();
                NewItemProject.Name = NameProjectEditText.Text;
                NewItemProject.Description = DescriptionProjectEditText.Text;
                ScrumHelper.BL.Managers.ProjectManager.SaveProject(NewItemProject);
                Finish();
            };
            CancelButton.Click += delegate
            {
                //SetContentView (Resource.Layout.EditProject);
                //StartActivity(typeof(EditProjectActivity));
                Finish();
            };

           
        }

        protected override void OnResume()
        {
            base.OnResume();

        }
    }
}

