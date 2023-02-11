using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_MVC;
using System.Data.Entity;
using Assignment_MVC.Models;

namespace Assignment_MVC.Controllers
{
    public class AssignmentController : Controller
    {
        NorthwindEntities tb = new NorthwindEntities();
        // GET: Assignment
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult GetData()
        {

            //tb.Cust_Data().ToList();
            
            return View(tb.Cust_Data().ToList());
        }
        public ActionResult GetOrderData()
        {
            // tb.ord_data().ToList(); 
            //tb.SaveChanges();
            return View("GetOrderData", tb.ord_data().Where(x => x.OrderID == 10248).ToList());   
        }
    }
}