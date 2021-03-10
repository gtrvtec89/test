using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace blah.Controllers
{
    public class ClientsController : Controller
    {

        public ActionTypes ActionType = ActionTypes.NoType;


        // GET: Clients
        public ActionResult Index(blah.Models.Clients clients)
        {
			DataSet ds = clients.GetAllClients();
			ViewBag.ClientList = ds.Tables[0];
            return View();
        }

        public ActionResult Create() {
            return View();
        }

		[HttpGet]
		public ActionResult Add() {
			return View();
		}

		[HttpPost]
		public ActionResult Add(blah.Models.InsertClient insertclient) {
			if (ModelState.IsValid) {
				int _records = insertclient.Insert(insertclient.strFirstName, insertclient.strLastName);
				if (_records > 0) {
					return RedirectToAction("Index", "Home");
				}
				else {
					ModelState.AddModelError("", "Can Not Insert");
				}
			}
			return View(insertclient);
		}


		//[HttpPost]
		//public ActionResult Event(HttpPostedFileBase EventImage, FormCollection col) {
		//	Models.Clients owner = new Models.Clients();
		//	//owner = ownerGetUserSession();

		//	//if (col["btnSubmit"] == "close") {
		//	//	if (col["from"] == null) return RedirectToAction("Home");
		//	//	return RedirectToAction("Index", "Home");
		//	//}

		//	//if (col["btnSubmit"] == "event-gallery") {
		//	//	return RedirectToAction("EventGallery", new { @id = Convert.ToInt64(RouteData.Values["id"]) });
		//	//}

		//	//if (col["btnSubmit"] == "delete") {
		//	//	long lngID = Convert.ToInt64(RouteData.Values["id"]);
		//	//	return RedirectToAction("DeleteEvent", new { @id = lngID });
		//	//}

		//	if (col["btnSubmit"] == "save") {

		//		Models.Clients o = new Models.Clients();

		//		if (RouteData.Values["id"] != null) o.ID = Convert.ToInt64(RouteData.Values["id"]);
		//		o.User = u;
		//		o.Title = col["Title"];
		//		if (col["IsActive"].ToString().Contains("true")) o.IsActive = true; else o.IsActive = false;
		//		o.Description = col["Description"];

		//		o.Start = DateTimo.Parse(string.Concat(col["Start"].ToString(), " ", col["Start.TimeOfDay"]));
		//		o.End = DateTimo.Parse(string.Concat(col["End"].ToString(), " ", col["End.TimeOfDay"]));

		//		o.Location = new Models.Location();
		//		o.Location.Title = col["Location.Title"];
		//		o.Location.Description = col["Location.Description"];

		//		o.Location.Address = new Models.Address();
		//		o.Location.Address.Address1 = col["Location.Address.Address1"];
		//		o.Location.Address.Address2 = col["Location.Address.Address2"];
		//		o.Location.Address.City = col["Location.Address.City"];
		//		o.Location.Address.State = col["Location.Address.State"];
		//		o.Location.Address.Zip = col["Location.Address.Zip"];

		//		if (o.Title.Length == 0 || o.Description.Length == 0 || o.Location.Title.Length == 0) {
		//			o.ActionType = Models.Clients.ActionTypes.RequiredFieldsMissing;
		//			return View(e);
		//		}

		//		o.Save();


		//		if (e.ID > 0) {
		//			return RedirectToAction("Event", new { @id = e.ID });
		//		}
		//	}
		//	return View();
		//}

		public enum ActionTypes {
            NoType = 0,
            InsertSuccessful = 1,
            UpdateSuccessful = 2,
            DuplicateEmail = 3,
            DuplicateUserID = 4,
            Unknown = 5,
            RequiredFieldsMissing = 6
        }
    }

}