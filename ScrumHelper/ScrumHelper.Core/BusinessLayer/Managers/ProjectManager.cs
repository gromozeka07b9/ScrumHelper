using System;
using System.Collections.Generic;
using ScrumHelper.BL;

namespace ScrumHelper.BL.Managers
{
	public static class ProjectManager
	{
		static ProjectManager ()
		{
		}
		
		public static Project GetProject(int id)
		{
			return DAL.Repository.GetItem(id);
		}
		
		public static IList<Project> GetProjects ()
		{
			return new List<Project>(DAL.Repository.GetProjects());
		}
		
		public static int SaveProject (Project item)
		{
			return DAL.Repository.SaveProject (item);
		}
		
		public static int DeleteProject(int id)
		{
			return DAL.Repository.DeleteProject(id);
		}		
	}
}