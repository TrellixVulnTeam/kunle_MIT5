﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using Microsoft.AspNetCore.Identity;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }


        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/createUser")]
        public IActionResult CreateUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists!");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                dbContext.Add(newUser);
                dbContext.SaveChanges();

                User thisUser = dbContext.Users.Last();
                int id = thisUser.UserId;

                HttpContext.Session.SetInt32("UserId", id);
                HttpContext.Session.SetString("UserName", thisUser.FirstName);

                return RedirectToAction("Success", new{id = id});
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/signin")]
        public IActionResult UserLogin(myUser thisUser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == thisUser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("Login");
                }

                var hasher = new PasswordHasher<myUser>();
                var result = hasher.VerifyHashedPassword(thisUser, userInDb.Password, thisUser.Password);

                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("Login");
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                HttpContext.Session.SetString("UserName", userInDb.FirstName);
                return RedirectToAction("success", new{id = userInDb.UserId});
            }
            return View("Login");
        }

        [HttpGet("/account/{id}")]
        public IActionResult Success(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if(userId == null)
            {
                return RedirectToAction("Login");
            }
            ViewModel trans = new ViewModel
            {
                thisUser = dbContext.Users.Include(u => u.UserTransactions)
                .FirstOrDefault(u => u.UserId == (int)userId)

                // allTransactions = dbContext.Transactions.Where(u => u.UserId == (int)userId).ToList()
            };

            return View(trans);
        }

        [HttpPost("process/trans")]
        public IActionResult Transaction(Transaction newTrans)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            newTrans.UserId = (int)userId;
            dbContext.Transactions.Add(newTrans);
            dbContext.SaveChanges();

            return RedirectToAction("Success", new{id = (int)userId});
        }

        [HttpGet("/logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    } 
}
