using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Managment.Models;

namespace Employee_Managment.Controllers
{
	public class AdminController : Controller
	{
		Emp_ManagmentEntities db = new Emp_ManagmentEntities();
		// GET: Admin
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(empDetail emp_obj)
		{
			var find = db.empDetails.FirstOrDefault(u => u.email == emp_obj.email);
			if (find == null)
			{ 
			emp_obj.created_date = System.DateTime.Now;
			db.empDetails.Add(emp_obj);
			db.SaveChanges();
			loginDetail lg = new loginDetail();
			lg.loginId = emp_obj.email;
			lg.password = emp_obj.email;
			lg.role = "Employee";
			lg.status = "Active";
			lg.created_date = System.DateTime.Now;
			db.loginDetails.Add(lg);
			db.SaveChanges();
				ViewData["msg"] = "Save & Updated Successfully";
			}
		else
		{
			ViewData["msg"] = "Details already exist";
			}
			return View();
		}
		public ActionResult Manage()
		{
			var get_emp = db.empDetails.OrderByDescending(u => u.id).ToList();
			return View(get_emp);
		}
	}
}