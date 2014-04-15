using System;
using System.Collections.Generic;
using ScrumHelper.BL;

namespace ScrumHelper.BL.Managers
{
	public static class TaskManager
	{
		static TaskManager ()
		{
		}
		
		public static Employee GetEmployee(int id)
		{
			//return DAL.TaskRepository.GetTask(id);
			return new Employee ();
		}
		
		/*public static IList<Task> GetTasks ()
		{
			return new List<Task>(DAL.TaskRepository.GetTasks());
		}
		
		public static int SaveTask (Task item)
		{
			return DAL.TaskRepository.SaveTask(item);
		}
		
		public static int DeleteTask(int id)
		{
			return DAL.TaskRepository.DeleteTask(id);
		}*/
		
	}
}