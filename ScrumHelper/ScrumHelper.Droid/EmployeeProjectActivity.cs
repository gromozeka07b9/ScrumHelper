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
    [Activity(Label = "EmployeeProject")]            
    public class PersonProjectActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.EmployeeProject);
            Button addEmployeeButton = FindViewById<Button>(Resource.Id.addEmployeeButton);
            addEmployeeButton.Click += delegate
            {             
                StartActivity(typeof(EditEmployeeActivity));
            };
            ListView listEmployeeListView = FindViewById<ListView>(Resource.Id.listEmployeesListView);
            listEmployeeListView.ItemClick += delegate
            {
                //SetContentView (Resource.Layout.EditProject);
                StartActivity(typeof(EditEmployeeActivity));
            };
            UpdateListEmployee();
        }

        void CreateDefaultData()
        {
            Employee itemEmp = new Employee(){ Name = "Ваш первый сотрудник", Email = "test@test.com" };
            ScrumHelper.BL.Managers.EmployeeManager.Save(itemEmp);
        }

        void UpdateListEmployee()
        {
            var ExistsEmployees = ScrumHelper.BL.Managers.EmployeeManager.GetItems();
            if (ExistsEmployees.Count < 1)
            {
                CreateDefaultData();
                ExistsEmployees = ScrumHelper.BL.Managers.EmployeeManager.GetItems();
            }
            var ListEmployeeStrings = new List<string>();
            foreach (var item in ExistsEmployees)
            {
                ListEmployeeStrings.Add(item.Name);
            }
            ListView lv = FindViewById<ListView>(Resource.Id.listEmployeesListView);
            lv.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, ListEmployeeStrings.ToArray());

        }
    }
}

