using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blah.Models {
	public class Pets {

	public int intPetID            { get; set; }
	public string strPetNumber 	   { get; set; }
    public string strMicrochipID   { get; set; }    
    public string strPetName       { get; set; }    
    public int intPetTypeID        { get; set; } 
	public int intGenderID   	   { get; set; }
    public int intBreedID          { get; set; } 
	public string dtmDateofBirth   { get; set; }
    public double dblWeight        { get; set; }    
	public int isBlind             { get; set; }
    public int isDeaf              { get; set; } 
	public int isAggressive        { get; set; }
    public int isDeceased          { get; set; } 
	public int isAllergic          { get; set; }
    public string strColor         { get; set; }    
    public string strNotes         { get; set; }    
    public int isActive { get; set; }
	public int intOwnerID { get; set; }
	}
}