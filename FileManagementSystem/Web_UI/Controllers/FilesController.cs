﻿using BAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_UI.Controllers
{
    public class FilesController : Controller
    {
        IFileService fileService;
        public FilesController()
        {
            fileService = new FileService();
        }
        // GET: Files
        public ActionResult Index()
        {
            IEnumerable<Files> files = fileService.GetAll();
            return View(files);
        }

        // GET: Files/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Files/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Files/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Files/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Files/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Files/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Files/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
