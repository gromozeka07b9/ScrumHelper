using System;
using ScrumHelper.BL.Contracts;
using ScrumHelper.DL.SQLite;

namespace ScrumHelper.BL
{
	/// <summary>
	/// Описание объекта Проект
	/// </summary>
	public class Project : IBusinessEntity
	{
		public Project ()
		{
		}

		[PrimaryKey, AutoIncrement, Indexed]
        public int ID { get; set; }
		/// <summary>
		/// Краткое наименование проекта
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		/// <summary>
		/// Описание проекта
		/// </summary>
		/// <value>The description.</value>
		public string Description { get; set; }
		/// <summary>
		/// Пометка удаления объекта
		/// </summary>
		/// <value><c>true</c> if delete mark; otherwise, <c>false</c>.</value>
		[Indexed]
		public int DeleteMark { get; set; }
	}
}

