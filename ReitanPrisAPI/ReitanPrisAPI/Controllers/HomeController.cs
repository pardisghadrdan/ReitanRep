using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ReitanPrisAPI.Models;

namespace ReitanPrisAPI.Controllers
{
    public class HomeController : ApiController
    {
        List<EmpModel> EmpDet = new List<EmpModel>
        {
            new EmpModel(1, "Pardis", "Stockholm"),
            new EmpModel(2, "Kalle", "Sundsvall"),

        };

        //[System.Web.Http.Route("baseaddress/api/Prices/{store}?changeddate=”2018-01-01”&itemnr=”12545”")]
        [System.Web.Http.HttpGet]
        public IEnumerable<EmpModel> GetEmpDetails()
        {
            return EmpDet;

            //List<EmpModel> ObjList = new List<EmpModel>();

            //var EmpList = (from a in EmpDet
            //               where a.EmpId.Equals(id)
            //               select new { a.EmpId, a.Name, a.City }).ToList();
            //return ObjList;
        }


        //public ActionResult Index()
        //{
        //    ViewBag.Title = "Home Page";

        //    return View();
        //}
    }
}
 