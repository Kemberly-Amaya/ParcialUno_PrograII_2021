using KemberlyCatalinaAmayaSerrano.Models.VIEWSMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KemberlyCatalinaAmayaSerrano.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Monto(CajeroViewsModels cajero)
        {
            int ConvertMonto = Convert.ToInt32(cajero.Monto);
            if (ConvertMonto % 5 == 0)
            { 
            
            
            
            
            }

                return View();
        }

       
    }
}