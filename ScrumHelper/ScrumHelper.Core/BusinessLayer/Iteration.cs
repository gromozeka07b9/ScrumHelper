using System;
using ScrumHelper.BL.Contracts;
using ScrumHelper.DL.SQLite;

namespace ScrumHelper.BL
{
	/// <summary>
	/// Represents a Task.
	/// </summary>
	public class Iteration : IBusinessEntity
	{
		public Iteration ()
		{
		}

		[PrimaryKey, AutoIncrement]
        public int ID { get; set; }
		/// <summary>
		/// Наименование итерации
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		/// <summary>
		/// Описание итерации
		/// </summary>
		/// <value>The description.</value>
		public string Description { get; set; }
		/// <summary>
		/// Дата начала итерации
		/// </summary>
		/// <value></value>
		public DateTime DateStart { get; set; }
		/// <summary>
		/// Дата завершения итерации
		/// </summary>
		/// <value></value>
		public DateTime DateEnd { get; set; }
		/// <summary>
		/// Проект, к которому относится итерация
		/// </summary>
		/// <value></value>
		public Project OwnerProject { get; set; }
		/// <summary>
		/// Пометка удаления объекта
		/// </summary>
		/// <value><c>true</c> if delete mark; otherwise, <c>false</c>.</value>
		public int DeleteMark { get; set; }
	}
}

