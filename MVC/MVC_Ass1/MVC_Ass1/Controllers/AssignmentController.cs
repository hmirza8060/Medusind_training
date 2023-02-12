using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Ass1.Controllers
{
    public class AssignmentController : Controller
    {
        NorthwindEntities1 db=new NorthwindEntities1();
        // GET: Assignment
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }
        public ActionResult Orderid()
        {
            return View(db.Orders.Where(a=> a.OrderID ==10248 ).ToList());
        }
        public ActionResult CInGermany()
        {
            var r = from i in db.Customers where i.Country == "Germany" select i;
            return View(r);
        }
    }
}