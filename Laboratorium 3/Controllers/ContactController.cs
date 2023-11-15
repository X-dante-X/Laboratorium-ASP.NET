﻿using Laboratorium_3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Laboratorium_3.Controllers
{

    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> organizations = CreateOrganizationItemList();
            Contact model = new Contact();
            model.OrganizationList = organizations;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            model.OrganizationList = CreateOrganizationItemList();
            return View();
        }

        private List<SelectListItem> CreateOrganizationItemList()
        {
            var gr = new SelectListGroup() { Name = "Organizacje" };
            return _contactService.FindAllOrganizations()
                .Select(e => new SelectListItem() { Text = e.Name, Value = e.Id.ToString(), Group = gr })
                .Append(new SelectListItem(){ Text = "Brak organizacji", Value = "", Selected = true, Group = new SelectListGroup() { Name = "Brak" } })
                .ToList();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = _contactService.FindById(id);
            model.OrganizationList = CreateOrganizationItemList() ;
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.DeleteById(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contactService.FindById(id));
        }
        [HttpPost]
        public IActionResult Details(Contact model)
        {
            return RedirectToAction("Index");
        }
    }
}
