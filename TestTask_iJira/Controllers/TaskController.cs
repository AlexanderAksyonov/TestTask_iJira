using Jira.Storage.Avstract;
using Jira.Storage.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask_Jira.Models;

namespace TestTask_Jira.Controllers
{
    public class TaskController : Controller
    {
        private ITaskRepository repository;

        public TaskController (ITaskRepository taskRepository)
        {
            this.repository = taskRepository;
        }

        public ViewResult TaskList()
        {
            List<TaskModel> model = new List<TaskModel> ();

            model.AddRange(repository.JiraTask.Select(m => new TaskModel ()
                {
                    TaskID = m.TaskID, 
                    Header = m.Header,
                    IsComplite = m.Complite, 
                    Selected = false
                }).ToList());

            return View(model);
        }

        [HttpPost]
        public ActionResult SendTask(string Header)
        {
            repository.SaveTask(Header, false);
            return RedirectToAction("TaskList");
        }

        [HttpPost]
        public ActionResult CloseTask (ICollection<TaskModel> model)
        {
            foreach (var messId in model.Where(m=>m.Selected).Select(s=>s.TaskID))
            {
                repository.CloseTasks(messId);
            }
            return RedirectToAction("TaskList");
        }

    }
}
