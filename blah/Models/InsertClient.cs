using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;

namespace blah.Models {
	public class InsertClient {

        [Required]
        [Display(Name = "First Name:")]
        public string strFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name:")]
        public string strLastName { get; set; }
        public int Insert(string _strFirstName, string _strLastName) {
            SqlConnection cn = new SqlConnection(@"Data Source = LAPTOP - GOR8KCK9\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("Insert Into TOwners(strFirstName,strLastName)Values('" + _strFirstName + "','" + _strLastName + "')", cn);
            cn.Open();
            return cmd.ExecuteNonQuery();
        }

    }
}