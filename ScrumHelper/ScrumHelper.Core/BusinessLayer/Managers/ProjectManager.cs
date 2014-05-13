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
            DAL.Repository<Project> prj = new ScrumHelper.DAL.Repository<Project>();
            return prj.GetItem(id);
        }

        public static IList<Project> GetItems()
        {
            DAL.Repository<Project> prj = new ScrumHelper.DAL.Repository<Project>();
            return new List<Project>(prj.GetItems());
        }

        public static int Save(Project item)
        {
            DAL.Repository<Project> prj = new ScrumHelper.DAL.Repository<Project>();
            return prj.Save(item);
        }

        public static int Delete(int id)
        {
            DAL.Repository<Project> prj = new ScrumHelper.DAL.Repository<Project>();
            return prj.Delete(id);
        }
    }
}