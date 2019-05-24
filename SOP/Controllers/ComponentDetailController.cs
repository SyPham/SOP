using Model.dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOP.Controllers
{
    public class ComponentDetailController : Controller
    {
        // GET: ComponentDetail
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(ComponentDetail entity)
        {
            var result = new ComponentDetailDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
    }
}