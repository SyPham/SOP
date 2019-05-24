using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.dao;
using Model.EF;

namespace SOP.Controllers
{
    public class MachineController : Controller
    {

        // GET: Machine
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Machine entity)
        {
            var result = new MachineDao().Add(entity);

            return Json(result > 0 ? true : false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Machine entity)
        {
            return Json(new MachineDao().Update(entity), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int Id)
        {
            return Json(new MachineDao().Delete(Id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListAll()
        {
            return Json(new MachineDao().ListAll(), JsonRequestBehavior.AllowGet);
        }
    }
}