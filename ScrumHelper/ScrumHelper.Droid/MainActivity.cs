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
    [Activity(Label = "ScrumHelper", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            Button editProjectButton = FindViewById<Button>(Resource.Id.editProjectButton);
            editProjectButton.Click += delegate
            {
                //SetContentView (Resource.Layout.EditProject);
                StartActivity(typeof(EditProjectActivity));
            };
            ListView listProjectsListView = FindViewById<ListView>(Resource.Id.listProjectsListView);
            listProjectsListView.ItemClick += delegate
            {
                //SetContentView (Resource.Layout.EditProject);
                StartActivity(typeof(ActionProjectActivity));
            };
            UpdateListProject();
        }

        protected override void OnResume()
        {
            base.OnResume();
            UpdateListProject();
        }

        bool FirstStartApp()
        {
            return true;
        }
        /*void SetActiveLayoutProjects()
        {
            SetContentView (Resource.Layout.Main);
        }

        void SetActiveLayoutFirstStart()
        {
            SetContentView (Resource.Layout.FirstStart);
        }*/
        void CreateDefaultData()
        {
            Project prj = new Project(){ Name = "Ваш первый проект" };
            ScrumHelper.BL.Managers.ProjectManager.SaveProject(prj);
        }

        void UpdateListProject()
        {
            var ExistsProjects = ScrumHelper.BL.Managers.ProjectManager.GetProjects();
            if (ExistsProjects.Count < 1)
            {
                CreateDefaultData();
                ExistsProjects = ScrumHelper.BL.Managers.ProjectManager.GetProjects();
            }
            var ListProjectsStrings = new List<string>();
            foreach (var item in ExistsProjects)
            {
                ListProjectsStrings.Add(item.Name);
            }
            ListView lv = FindViewById<ListView>(Resource.Id.listProjectsListView);
            lv.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, ListProjectsStrings.ToArray());

        }
    }
}


