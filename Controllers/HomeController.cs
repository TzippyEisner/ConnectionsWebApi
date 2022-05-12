using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConnectionsWebApi.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Title = "Home Page";

      return View();
    }

    //[System.Web.Http.HttpGet]
    //public string GetCustomer(int customerId)
    //{
    //  try
    //  {
    //    Customer customer;
    //    using (var db = new Weekend2011Entities())
    //    {
    //      customer = db.Customer.FirstOrDefault(x => x.customerID == customerId);
    //    }
    //    return customer.customerName;
    //  }
    //  catch (Exception ex)
    //  {
    //    throw ex;
    //  }
    //}
  }
}
