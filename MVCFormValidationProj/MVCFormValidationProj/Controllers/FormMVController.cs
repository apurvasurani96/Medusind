using MVCFormValidationProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MVCFormValidationProj.Controllers
{
    public class FormMVController : Controller
    {
        // GET: FormMV
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetDetail(MVCFormValidation mv )
        {
            if(ModelState.IsValid)
            {
                return View(mv);
            }
            else
            {
                return View(mv);
            }
            //return View();
        }
    }
}