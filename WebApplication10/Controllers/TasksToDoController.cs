using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;


namespace WebApplication10.Controllers
{
    public class TasksToDoController : Controller
    {
        List<TasksToDo> _tasks = new List<TasksToDo>{
            new TasksToDo{RedenBroj = 1, Description = "Fix the apply button" , StartDate = new DateTime(2020,09,09), IsFinished = false},
            new TasksToDo{RedenBroj = 2, Description = "Add new design in contact page" , StartDate = new DateTime(2020,09,09), EndDate = new DateTime(2020,09,10),IsFinished = true, NumberOfHours = 3},
            new TasksToDo{RedenBroj = 3, Description = "Put index on database on table countries" , StartDate = new DateTime(2020,09,09), IsFinished = false},
            new TasksToDo{RedenBroj = 4, Description = "Service for sending emails" , StartDate = new DateTime(2020,09,09), IsFinished = false},
            new TasksToDo{RedenBroj = 5, Description = "Add authorization to the project  " , StartDate = new DateTime(2020,09,09), EndDate = new DateTime(2020,11,11),IsFinished = true, NumberOfHours = 2}
        };
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult List()
        {
            
            return View(_tasks);
        }
    }
}