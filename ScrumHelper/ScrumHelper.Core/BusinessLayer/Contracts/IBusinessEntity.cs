using System;

namespace ScrumHelper.BL.Contracts {
	public interface IBusinessEntity {
		int ID { get; set; }
		int DeleteMark {get; set;}

	}
}

