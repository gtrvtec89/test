using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace blah.Models {
	public class Database {

		private bool GetDBConnection(ref SqlConnection SQLConn) {
			try {
				if (SQLConn == null) SQLConn = new SqlConnection();
				if (SQLConn.State != ConnectionState.Open) {
					SQLConn.ConnectionString = ConfigurationManager.AppSettings["AppDBConnect"];
					SQLConn.Open();
				}
				return true;
			}
			catch (Exception ex) { throw new Exception(ex.Message); }
		}


		//public Clients.ActionTypes Create(Clients owner) {
		//	try {
		//		SqlConnection cn = null;
		//		if (!GetDBConnection(ref cn)) throw new Exception("Database did not connect");
		//		SqlCommand cm = new SqlCommand("INSERT_EVENTS", cn);
		//		int intReturnValue = -1;

		//		SetParameter(ref cm, "@id", e.ID, SqlDbType.BigInt, Direction: ParameterDirection.Output);
		//		SetParameter(ref cm, "@owner_uid", e.User.UID, SqlDbType.BigInt);
		//		SetParameter(ref cm, "@title", e.Title, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@desc", e.Description, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@start_date", e.Start, SqlDbType.DateTime);
		//		SetParameter(ref cm, "@end_date", e.End, SqlDbType.DateTime);
		//		SetParameter(ref cm, "@location_title", e.Location.Title, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@location_desc", e.Location.Description, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@address1", e.Location.Address.Address1, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@address2", e.Location.Address.Address2, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@city", e.Location.Address.City, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@state", e.Location.Address.State, SqlDbType.NVarChar);
		//		SetParameter(ref cm, "@zip", e.Location.Address.Zip, SqlDbType.NVarChar);

		//		if (e.IsActive)
		//			SetParameter(ref cm, "@is_active", "Y", SqlDbType.Char);
		//		else
		//			SetParameter(ref cm, "@is_active", "N", SqlDbType.Char);

		//		SetParameter(ref cm, "ReturnValue", 0, SqlDbType.TinyInt, Direction: ParameterDirection.ReturnValue);

		//		cm.ExecuteReader();

		//		intReturnValue = (int)cm.Parameters["ReturnValue"].Value;
		//		CloseDBConnection(ref cn);

		//		switch (intReturnValue) {
		//			case 1: // new event created
		//				e.ID = (long)cm.Parameters["@id"].Value;
		//				return Event.ActionTypes.InsertSuccessful;
		//			default:
		//				return Event.ActionTypes.Unknown;
		//		}
		//	}
		//	catch (Exception ex) { throw new Exception(ex.Message); }
		//}


	}
}