using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_task2.Models;


namespace mvc_task2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult list()
        {
            List<UserModel> userList = new List<UserModel>();

            var user = new UserModel(1,"ashu","a", "a","123","Male","aa.jpg",1);
            userList.Add(user);
            return View(userList);
        }
        [HttpGet]
        public ActionResult SignUp()
        {
           
            
            UserModel userModel = new UserModel();
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries, "CountryId", "CountryName");
            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");
            ViewBag.countryDataSaurce = countryList;
            ViewBag.stateDataSaurce = stateList;
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserModel userModel)
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UserModel userModel)
        {
            return View();
        }

    }
}