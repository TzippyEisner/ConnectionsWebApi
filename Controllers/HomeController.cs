using Newtonsoft.Json;
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

    //https://localhost:44362/home/GetUserNameByUnique?uniqueID=1B2AC001-D56B-451E-A794-0AFB02E03B0D
    [System.Web.Http.HttpGet]
    public string GetUserNameByUnique(string uniqueID)
    {
      try
      {
        users user = new users();
        using (connectionsEntities db = new connectionsEntities())
        {
          user = db.users.FirstOrDefault(x => x.UniqeID == uniqueID);
        }
        if (user != null)
          return user.FirstName + " " + user.LastName;
        return string.Empty;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
