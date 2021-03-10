using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blah.Models {
	public class Medications {

	public int intMedicationID { get; set; }
    public string strMedicationName { get; set; }
    public string strMedicationDesc { get; set; }             
    public double dblCost           { get; set; }             
    public double dblPrice          { get; set; }
    public string strNotes          { get; set; }             
    public int intQuantity          { get; set; }          
    public int intMethodID { get; set; }

    }
}