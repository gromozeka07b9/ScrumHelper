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
    [Activity(Label = "EmployeeProject")]            
    public class PersonProjectActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.EmployeeProject);

            UpdateListEmployee();
        }

        void UpdateListEmployee()
        {
            //var ExistsPersons = ScrumHelper.BL.Managers.EmployeeManager.GetEmployee;
            /*if (ExistsProjects.Count < 1)
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
*/
        }
    }
}

