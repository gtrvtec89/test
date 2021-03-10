using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace blah.Models {
	public class Employees {


		public string strFirstName { get; set; }
		public string strLastName { get; set; }
		public int intJobTitle { get; set; }
		public bool isActive { get; set; }
		public int intUserID { get; set; }

	}
}