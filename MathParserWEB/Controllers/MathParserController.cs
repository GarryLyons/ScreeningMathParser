using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL = MathParserBL;

namespace MathParserWEB.Controllers
{
    public class MathParserController : Controller
    {
        //
        // GET: /MathParser/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Calc(string Value)
        {
            BL.MathParser mp = new BL.MathParser();
            BL.MPReturnObject ro = mp.Calculate(Value);

            return Json(ro, JsonRequestBehavior.AllowGet);
        }

    }
}
