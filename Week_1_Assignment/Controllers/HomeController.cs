 
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week_1_Assignment.Models;

namespace Week_1_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUser _user;

        public HomeController(IUser User)
        {
            _user = User;
        }

        public IActionResult Index()
        {
            var Users = _user.GetUsers();
            return View(Users);
        }
        public IActionResult Update(int id)
        {
            var Users = _user.GetDetailsByID(id);
            return View(Users);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            _user.UpdateUser(user);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int ID)
        {
            var Users = _user.DeleteUser(ID);
            return RedirectToAction("Index");
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _user.CreateUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult LoanCalculator()
        {
            return View();
        }
       
    }
}
