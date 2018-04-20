using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          List<Contact> allContact = Contact.GetAll();
          return View();
        }
    }
}
