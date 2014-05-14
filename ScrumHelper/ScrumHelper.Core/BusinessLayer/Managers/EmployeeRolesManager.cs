using ScrumHelper.BL;

namespace ScrumHelper.Core
{
    class EmployeeRolesManager
    {
        static EmployeeRolesManager()
        {
        }
        /*public static Project Get(int id)
        {
            DAL.Repository<Project> repos = new ScrumHelper.DAL.Repository<Project>();
            return repos.GetItem(id);
        }

        public static IList<Project> GetItems()
        {
            DAL.Repository<Project> repos = new ScrumHelper.DAL.Repository<Project>();
            return new List<Project>(repos.GetItems());
        }*/
        public static int Link(Project itemProject, Employee itemEmployee)
        {
            DAL.Repository<EmployeeRoles> repos = new ScrumHelper.DAL.Repository<EmployeeRoles>();
            EmployeeRoles item = new EmployeeRoles();
            item.EmployeeID = itemEmployee;
            item.ProjectID = itemProject;
            return repos.Save(item);
        }

        public static int UnLink(Project itemProject, Employee itemEmployee)
        {
            //DAL.Repository<Project> repos = new ScrumHelper.DAL.Repository<Project>();
            //return repos.Delete(id);
            return 0;
        }
    }
}

