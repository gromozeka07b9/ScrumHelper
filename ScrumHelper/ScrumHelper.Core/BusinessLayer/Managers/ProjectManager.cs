using System;
using System.Collections.Generic;
using ScrumHelper.BL;

namespace ScrumHelper.BL.Managers
{
    public static class ProjectManager
    {
        static ProjectManager()
        {
        }

        public static Project Get(int id)
        {
            DAL.Repository<Project> repos = new ScrumHelper.DAL.Repository<Project>();
            return repos.GetItem(id);
        }

        public static IList<Project> GetItems()
        {
            DAL.Repository<Project> repos = new ScrumHelper.DAL.Repository<Project>();
            return new List<Project>(repos.GetItems());
        }

        public static int Save(Project item)
        {
            DAL.Repository<Project> repos = new ScrumHelper.DAL.Repository<Project>();
            return repos.Save(item);
        }

        public static int Delete(int id)
        {
            DAL.Repository<Project> repos = new ScrumHelper.DAL.Repository<Project>();
            return repos.Delete(id);
        }
    }
}