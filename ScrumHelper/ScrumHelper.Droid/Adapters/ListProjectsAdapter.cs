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
    public class ListProjectsAdapter:BaseAdapter
    {
        List<Project> _projectList;
        Activity _activity;

        public ListProjectsAdapter(Activity activity)
        {
            FillListProjects();
        }

        public override int Count 
        {
            get { return _projectList.Count; }
        }

        public override Java.Lang.Object GetItem (int position)
        {
            return null; // could wrap a Contact in a Java.Lang.Object to return it here if needed
        }

        public override long GetItemId (int position)
        {
            return _projectList [position].ID;
        }

        public override View GetView (int position, View convertView, ViewGroup parent)
        {          
            var view = convertView ?? _activity.LayoutInflater.Inflate (Resource.Layout.Main, parent, false);
            //var contactName = view.FindViewById<TextView> (Resource.Id.ContactName);
            //var contactImage = view.FindViewById<ImageView> (Resource.Id.ContactImage);
            var projectName = view.FindViewById<ListView> (Resource.Id.listProjects);
            //projectName. = _projectList [position].Name;

            /*if (_contactList [position].PhotoId == null) {

                contactImage = view.FindViewById<ImageView> (Resource.Id.ContactImage);
                contactImage.SetImageResource (Resource.Drawable.contactImage);

            } else {

                var contactUri = ContentUris.WithAppendedId (ContactsContract.Contacts.ContentUri, _contactList [position].Id);
                var contactPhotoUri = Android.Net.Uri.WithAppendedPath (contactUri, Contacts.Photos.ContentDirectory);

                contactImage.SetImageURI (contactPhotoUri);
            }*/
            return view;
        }

        void FillListProjects()
        {
            //string[] projection = {ListProjectsAdapter };
            _projectList = new List<Project>();
            _projectList.Add(new Project(){ Name = "test222", Description = "testffffff" });
        }
    }
}

