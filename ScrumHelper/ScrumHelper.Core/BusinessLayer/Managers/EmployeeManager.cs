using System;
using System.Collections.Generic;
using ScrumHelper.BL;

namespace ScrumHelper.BL.Managers
{
	public static class EmployeeManager
	{
		static EmployeeManager ()
		{
		}
		
		public static Employee GetEmployee(int id)
		{
			//return DAL.TaskRepository.GetTask(id);
			return new Employee ();
		}
		
		/*public static IList<Employee> GetEmployees ()
		{
			//return new List<Task>(DAL.TaskRepository.GetTasks());
			return new List<Employee> (new Employee ());
		}
		
		public static int SaveEmployee (Employee item)
		{
			//return DAL.TaskRepository.SaveTask(item);
			return 0;
		}
		
		public static int DeleteEmployee(int id)
		{
			//return DAL.TaskRepository.DeleteTask(id);
			return 0;
		}*/
		
	}
}