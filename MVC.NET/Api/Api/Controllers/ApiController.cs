using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Api.Models;

namespace Api.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public JsonResult GetApi()
        {
            var Apis = new List<Api123>
            {
                 new Api123 { Id = 1, Name = "Laptop", Price = 750.00M },
                new Api123 { Id = 2, Name = "Tablet", Price = 300.00M },
                new Api123 { Id = 3, Name = "Smartphone", Price = 500.00M }
            };
            return Json(Apis, JsonRequestBehavior.AllowGet);
        }
    }
}