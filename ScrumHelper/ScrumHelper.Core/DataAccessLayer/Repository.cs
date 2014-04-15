using System;
using System.Collections.Generic;
using System.IO;
using ScrumHelper.BL;

namespace ScrumHelper.DAL 
{
	public class Repository 
	{
		DL.HelperDatabase db = null;
		protected static string dbLocation;		
		protected static Repository me;		

		static Repository ()
		{
			me = new Repository();
		}
		
		protected Repository()
		{
			// set the db location
			dbLocation = DatabaseFilePath;
			
			// instantiate the database	
			db = new ScrumHelper.DL.HelperDatabase(dbLocation);


		}
		
		public static string DatabaseFilePath 
		{
			get 
			{ 
				var sqliteFilename = "ScrumHelper.db3";

#if NETFX_CORE
                var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, sqliteFilename);
#else

#if SILVERLIGHT
				// Windows Phone expects a local path, not absolute
	            var path = sqliteFilename;
#else

#if __ANDROID__
				// Just use whatever directory SpecialFolder.Personal returns
	            string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); ;
#else
				// we need to put in /Library/ on iOS5.1 to meet Apple's iCloud terms
				// (they don't want non-user-generated data in Documents)
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
				string libraryPath = Path.Combine (documentsPath, "../Library/"); // Library folder
#endif
				var path = Path.Combine (libraryPath, sqliteFilename);
#endif		

#endif
				return path;	
			}
		}	

		public static Project GetItem(int id)
		{
			return me.db.GetItem<Project> (id);
		}

		public static IEnumerable<Project> GetProjects ()
		{

			return me.db.GetItems<Project>();
		}

		public static int SaveProject (Project item)
		{
			return me.db.SaveItem<Project> (item);
		}

		public static int DeleteProject(int id)
		{
			return me.db.DeleteItem<Project>(id);
		}
	}
}
