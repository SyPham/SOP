using Model.dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SOP.Controllers
{
    public class OperationController : Controller
    {
        // GET: Operation
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Model.EF.Operation entity)
        {
            var result = new OperationDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
    }
}