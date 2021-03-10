using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace blah.Models {


    public class Clients {

		public DataSet GetAllClients() {
			SqlConnection cn = new SqlConnection(@"Data Source = LAPTOP - GOR8KCK9\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
			SqlCommand cmd = new SqlCommand("Select intOwnerID,strFirstName,strLastName From TOwners", cn);
			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(ds);
			return ds;
		}


        

    }
}