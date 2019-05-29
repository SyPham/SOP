
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.dao;
using Model.EF;

namespace SOP.Controllers
{
    public class SOPController : Controller
    {
        // GET: SOP
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Model.EF.SOP entity)
        {
            var result = new SOPDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetMultipleData()
        {
            return Json(new SOPDao().MultipleData(), JsonRequestBehavior.AllowGet);
        }
    }
}