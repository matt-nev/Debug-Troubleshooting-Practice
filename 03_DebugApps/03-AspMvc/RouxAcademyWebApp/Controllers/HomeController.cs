using RouxAcademyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouxAcademyWebApp.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      // this controller method  is responsible 
      // for determining what to do with a request to 
      // http://oursite.com/home/Index

      var vm = new IndexViewModel();
			var model = new EventRepository();
			vm.SchoolEvents = model.GetAllEvents();
			return View(vm);
			
    }

    public ActionResult About()
    {
      // this controller method  is responsible 
      // for determining what to do with a request to 
      // http://oursite.com/home/about
      return View();
    }

   

    public ActionResult OtherPage(string id)
    {
      var vm = new PageViewModel();
      vm.PageTitle = id;
      return View(vm);
    }

   

    
  }
}