using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System;

namespace AddressBook.Controllers
{
    public class ContactController : Controller
    {
      [HttpGet("/contact")]
        public ActionResult Index()
        {
            List<Contact> allContact = Contact.GetAll();
            return View(allContact);
        }
      [HttpGet("/contact/new")]
      public ActionResult CreateForm()
      {
          return View();
      }
      [HttpPost("/contact")]
      public ActionResult Create()
      {
        Contact newContact = new Contact (Request.Form["new-name"], Request.Form["new-phoneNumber"], Request.Form["new-address"]);
        List<Contact> allContact = Contact.GetAll();
        return View("Index", allContact);
      }

      [HttpPost("/contact/delete")]
      public ActionResult DeleteAll()
      {
          Contact.ClearAll();
          return View();
      }
      [HttpGet("/contact/{id}")]
      public ActionResult Details(int id)
      {
          Contact contact = Contact.Find(id);
          return View(contact);
      }
    }
}
