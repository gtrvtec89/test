using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;

namespace blah.Models {


    public class Clients {

		//public string FirstName = String.Empty;
		//public string LastName = String.Empty;
		//public string Email = String.Empty;
		//public string Phone = String.Empty;
		//public string Address = String.Empty;
		//public string City = String.Empty;
		//public string State = String.Empty;
		//public string Zip = String.Empty;
		//public string Notes = String.Empty;
		[Display(Name = "First Name")]
		public string strO1FirstName { get; set; }
		public string strO1LastName { get; set; }
		public string strO1Address { get; set; }
		public string strO1Phone { get; set; }
		public string strO1Zip { get; set; }
		public string strO1Email { get; set; }
		public string strO1City { get; set; }
		public string strO1State { get; set; }
		public string strO1Notes { get; set; }

		// owner 2 information
		//public string strO2FirstName { get; set; }
		//public string strO2LastName { get; set; }
		//public string strO2Address { get; set; }
		//public string strO2Phone { get; set; }
		//public string strO2Email { get; set; }
		//public string strO2Notes { get; set; }

		[Display(Name = "First Name")]
		public string strO2FirstName { get; set; }
		[Display(Name = "Last Name")]
		public string strO2LastName { get; set; }
		[Display(Name = "Address")]
		public string strO2Address { get; set; }
		
		[Display(Name = "Phone")]
		public string strO2Phone { get; set; }
		[Display(Name = "Zip")]
		public string strO2Zip { get; set; }
		
		[Display(Name = "Email")]
		public string strO2Email { get; set; }
		[Display(Name = "City")]
		public string strO2City { get; set; }
		
		[Display(Name = "State")]
		public string strO2State { get; set; }
		[Display(Name = "Notes")]
		public string strO2Notes { get; set; }
	}
}