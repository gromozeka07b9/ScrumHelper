using ScrumHelper.BL.Contracts;
using ScrumHelper.BL;
using ScrumHelper.DL.SQLite;

namespace ScrumHelper.Core
{
    class EmployeeRoles : IBusinessEntity
    {
        public EmployeeRoles()
        {
        }

        [PrimaryKey, AutoIncrement, Indexed]
        public int ID { get; set; }

        public Project ProjectID { get; set; }
//ToDo: можно хранить сами объекты, а не ссылки?
        public Employee EmployeeID { get; set; }

        /// <summary>
        /// Пометка удаления объекта
        /// </summary>
        /// <value><c>true</c> if delete mark; otherwise, <c>false</c>.</value>
        [Indexed]
        public int DeleteMark { get; set; }
    }
}

