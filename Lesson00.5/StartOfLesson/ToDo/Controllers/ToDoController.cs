using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        public List<Models.ToDo> list = new List<Models.ToDo>
            {
                new Models.ToDo {Id = 1, Description = "Do Laundry", Status = new Status(){Id = 1, Value = "Pending" }},
                new Models.ToDo {Id = 2, Description = "Go To HEB", Status = new Status(){Id = 2, Value = "Pending" }},
                new Models.ToDo {Id = 3, Description = "Relax", Status = new Status(){Id = 3, Value = "Complete"}}
            };

        public IActionResult Index()
        {
            return View(list);
        }

    }
}
