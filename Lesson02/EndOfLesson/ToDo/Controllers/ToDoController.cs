﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        private static Dictionary<int, Status> status = new Dictionary<int, Status>
        {
            { 1, new Status { Id = 1, Value = "Not Started" } },
            { 2, new Status { Id = 2, Value = "In Progress" } },
            { 3, new Status { Id = 3, Value = "Done" } }
        };

        private static List<ToDo> list = new List<ToDo>
        {
            new ToDo
            {
                Id = 1,
                Title = "My First ToDo",
                Description = "Get the app working",
                Status = status[2],
                Created = DateTime.Now.AddDays(2)
            },
            new ToDo
            {
                Id = 2,
                Title = "Add DateTime",
                Description = "Should track when the ToDo was created",
                Status = status[1],
                Created = DateTime.Now.AddDays(10)
            },
            new ToDo
            {
                Id = 3,
                Title = "Add day-of-the-week TagHelper",
                Description = "Need an attribute we can use in our view that will pretty format the DateTime as a weekday when possible",
                Status = status[1],
                Created = null
            },
            new ToDo
            {
                Id = 4,
                Title = "Add ViewComponent",
                Description = "Should track when the ToDo was created",
                Status = status[1],
                Created = null
            }
        };

        // GET: ToDo
        public ActionResult Index()
        {
            return View(list);
        }

        // GET: ToDo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToDo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToDo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToDo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}