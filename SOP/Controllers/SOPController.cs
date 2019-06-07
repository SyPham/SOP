
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
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Model.EF.SOP entity)
        {
            var result = new SOPDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddProcess(Model.EF.Operation entity)
        {
            var result = new OperationDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddCategory(Model.EF.ComponentCategory entity)
        {
            var result = new ComponentCategoryDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddDetail(Model.EF.ComponentDetail entity)
        {
            var result = new ComponentDetailDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddMachine(Model.EF.Machine entity)
        {
            var result = new MachineDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddTreatment(Model.EF.Treatment entity)
        {
            var result = new TreatmentDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetMultipleData()
        {
            return Json(new SOPDao().MultipleData(), JsonRequestBehavior.AllowGet);
        }
         public JsonResult GetAll()
        {
            return Json(new SOPDao().GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}