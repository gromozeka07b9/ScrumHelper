using System;
using System.Collections.Generic;
using ScrumHelper.BL;

namespace ScrumHelper.BL.Managers
{
    public static class EmployeeManager
    {
        static EmployeeManager()
        {
        }

        public static Employee Get(int id)
        {
            DAL.Repository<Employee> repos = new ScrumHelper.DAL.Repository<Employee>();
            return repos.GetItem(id);
        }

        public static IList<Employee> GetItems()
        {
            DAL.Repository<Employee> repos = new ScrumHelper.DAL.Repository<Employee>();
            return new List<Employee>(repos.GetItems());
        }

        public static int Save(Employee item)
        {
            DAL.Repository<Employee> repos = new ScrumHelper.DAL.Repository<Employee>();
            return repos.Save(item);
        }

        public static int Delete(int id)
        {
            DAL.Repository<Employee> repos = new ScrumHelper.DAL.Repository<Employee>();
            return repos.Delete(id);
        }
    }
}