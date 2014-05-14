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
    [Activity(Label = "EditEmployee")]            
    public class EditEmployeeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.EditEmployee);

            Button AcceptButton = FindViewById<Button>(Resource.Id.AcceptButton);
            Button CancelButton = FindViewById<Button>(Resource.Id.CancelButton);
            AcceptButton.Click += delegate
            {
                EditText NameEmployeeEditText = FindViewById<EditText>(Resource.Id.NameEmployeeEditText);
                EditText EmailEmployeeEditText = FindViewById<EditText>(Resource.Id.EmailEmployeeEditText);
                Employee NewItemEmployee = new Employee();
                NewItemEmployee.Name = NameEmployeeEditText.Text;
                NewItemEmployee.Email = EmailEmployeeEditText.Text;
                ScrumHelper.BL.Managers.EmployeeManager.Save(NewItemEmployee);
                Finish();
            };
            CancelButton.Click += delegate
            {
                Finish();
            };
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}

