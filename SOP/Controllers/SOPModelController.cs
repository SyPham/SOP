using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.dao;
using Model.EF;

namespace SOP.Controllers
{
    public class SOPModelController : Controller
    {
        // GET: SOPModel
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(SOPModel entity)
        {
            var result = new SOPModelDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
    }
}