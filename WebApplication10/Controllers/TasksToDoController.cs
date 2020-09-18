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

        //How much wood would a woodchuck chuck if a woodchuck could chuck wood?


        // se koristi za da prikaze lista na taskovi. Vo view - to ima kopce 
        public IActionResult List()
        {

            return View(_tasks);
        }


        // delete metodot se koristi za da izbrise selektiran task.  Se povikuva od tabelata kaj listata na taskovi (List view)
        // Se povikuva so reden broj kako parametar i od listata od taskovi go trga taskot koj ima reden broj ednakov na toj od parametarot
        // na kraj pravi redirect do List viewto 
        public IActionResult Delete(int redenbroj)
        {
            // logika za brisenje na task od listata
            var tasks = _tasks.Where(a => a.RedenBroj != redenbroj).ToList();
            return View("List", tasks);
        }



        // pravi ednostaven prikaz na selektiran task
        public IActionResult Details(int redenbroj)
        {

            var task = _tasks.Where(a => a.RedenBroj == redenbroj).FirstOrDefault();
            return View(task);
        }



        // Ovde e toj tricky del malce :)
        // Imame po dva action methods za create i edit 
        // Za create: Prviot action metod - CreateForm vraka view kade treba da se prikaze formata kade korisnikot ke moze da vnesuva informacii
        // So submit na formata aftomatski se aktivira drugiot Create action method(vo formata mu imame kazano koj action metod da se aktivira)
        // Ovaj vtoriov action metod cie ime e samo Create, za zadaca ima da go dodade vo listata na taskovi novo vneseniot task i na kraj povtorno
        // da ne vrati vo viewto List.
        // Viewto od ovoj action metod go kreiravme so templejt: Add view pa selektirame Template: Create i Model: TasksToDo

        public IActionResult CreateForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(TasksToDo task)
        {
            // logika za dodavanje na nov task vo listata
            _tasks.Add(task);
            return View("List", _tasks);
        }


        // Istoto kako za Create, so edna minimalna razlika, formata za edit e popolneta so podatoci od selektiraniot task. 
        public IActionResult EditForm(int redenbroj)
        {
            // logika za zemanje na seleketiraniot task
            var item = _tasks.Where(a => a.RedenBroj == redenbroj).FirstOrDefault();
            return View(item);
        }


        [HttpPost]
        public IActionResult Edit(TasksToDo task)
        {
            // logika za edit na task vo listata. Prvo go naogame odredeniot task pa prajme re assign na editiranite polinja
            foreach (var item in _tasks)
            {
                if (item.RedenBroj == task.RedenBroj)
                {
                    item.Description = task.Description;
                    item.StartDate = task.StartDate;
                    item.EndDate = task.EndDate;
                    item.IsFinished = task.IsFinished;
                    item.NumberOfHours = task.NumberOfHours;
                }
            }
            return View("List", _tasks);
        }

    }
}