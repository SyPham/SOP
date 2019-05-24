using Model.dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOP.Controllers
{
    public class ComponentCategoryController : Controller
    {
        // GET: ComponantCategory
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(ComponentCategory entity)
        {
            var result = new ComponentCategoryDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
    }
}