using BusinessLayer;
using DataLayers;
using Models;
using SanskarHeights.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SanskarHeights.Controllers
{
    public class HomeController : Controller
    {
        EmployeeLogic employeeLogic = new EmployeeLogic(new EmployeeDetails());
        StudentLogic studentLogic = new StudentLogic(new StudentData());
        StandardLogic standardLogic = new StandardLogic(new StandardData()); 
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult SignIn(string name, string password)
        {
            bool isAuthenticated = employeeLogic.CheckEmployee(name, password);
            if (isAuthenticated )
            {
                FormsAuthentication.SetAuthCookie(name, false);

                var authTicket = new FormsAuthenticationTicket(1, name, DateTime.Now, DateTime.Now.AddMinutes(20), false, name);
                string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                HttpContext.Response.Cookies.Add(authCookie);
                return RedirectToAction("Index");
            }

            else
            {
                ModelState.AddModelError("", "Password does not match or account does not exists");
                return View();
            }
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("SignIn");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[Authorize]
        public ActionResult ShowDetails()
        {
            StandardModel standardModel=new StandardModel();
            standardModel.standards = new List<SelectListItem>();
            List<Standard> standards = standardLogic.GetStandards().ToList();
            standards.ForEach(x =>
            {
                standardModel.standards.Add(new SelectListItem() { Text = x.ClassName, Value = x.ClassId.ToString() });
            });

            return View(standardModel);
        }
        //[Authorize]
        //[ChildActionOnly]
        public PartialViewResult GetStudents(StandardModel _standardModel)
        {
            int standardid = Convert.ToInt32(_standardModel.Standard);
            List<Student> studentsList = studentLogic.GetStudentClassWise(standardid).ToList();

            return PartialView(studentsList);
        }
        
    }
}