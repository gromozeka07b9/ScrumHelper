using System;
using ScrumHelper.BL.Contracts;
using ScrumHelper.DL.SQLite;

namespace ScrumHelper.BL
{
    /// <summary>
    /// Represents a Task.
    /// </summary>
    public class Employee : IBusinessEntity
    {
        public Employee()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Адрес почты
        /// </summary>
        /// <value></value>
        public string Email { get; set; }

        /// <summary>
        /// Роль сотрудника
        /// </summary>
        /// <value></value>
        //public string Role { get; set; }
        /// <summary>
        /// Проект, к которому относится сотрудник
        /// </summary>
        /// <value></value>
        //public Project OwnerProject { get; set; } ссылка должна быть из проекта на сотрудника чтобы не дублировать сотрудников

        /// <summary>
        /// Пометка удаления объекта
        /// </summary>
        /// <value><c>true</c> if delete mark; otherwise, <c>false</c>.</value>
        public int DeleteMark { get; set; }
    }
}

