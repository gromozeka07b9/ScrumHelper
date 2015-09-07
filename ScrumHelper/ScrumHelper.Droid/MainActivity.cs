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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
            SetClickEvents();

            UpdateListProject();
        }

        void SetClickEvents()
        {
            Button editProjectButton = FindViewById<Button>(Resource.Id.editProjectButton);
            editProjectButton.Click += delegate
            {
                StartActivity(typeof(EditProjectActivity));
            };
            ListView listProjectsListView = FindViewById<ListView>(Resource.Id.listProjectsListView);
            listProjectsListView.ItemClick += delegate
            {
                StartActivity(typeof(ActionProjectActivity));
            };
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

        void CreateDefaultData()
        {
            Project prj = new Project { Name = "Ваш первый проект" };
            int result = ScrumHelper.BL.Managers.ProjectManager.Save(prj);
            if (result != 0)
            {
                //ошибка
            }
        }

        void UpdateListProject()
        {
            var ExistsProjects = ScrumHelper.BL.Managers.ProjectManager.GetItems();
            if (ExistsProjects.Count < 1)
            {
                CreateDefaultData();
                ExistsProjects = ScrumHelper.BL.Managers.ProjectManager.GetItems();
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


