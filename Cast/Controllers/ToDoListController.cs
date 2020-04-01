﻿using Cast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cast.Controllers
{
    public class ToDoListController : Controller
    {
        private ToDoListService toDoListService;

        public ToDoListController(ToDoListService service)
        {
            this.toDoListService = service;
        }

        // GET: ToDoList
        public ActionResult Index()
        {
            var model = toDoListService.GetToDoList();

            return View(model);
        }
    }
}