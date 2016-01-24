using System.Collections.Generic;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace ToDoList
{

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
              return View["index.cshtml"];
            };
            Get["/tasks"] = _ => {
              List<Task> AllTasks = Task.GetAll();
              return View["tasks.cshtml", AllTasks];
            };
            Get["/tasks/new"] = _ => {
              return View["tasks_form.cshtml"];
            };
            Post["/tasks/new"] = _ => {
              Task newTask = new Task(Request.Form["task-description"], 1);
              newTask.Save();
              return View["success.cshtml"];
            };
            Post["/tasks/delete"] = _ => {
              Task.DeleteAll();
              return View["cleared.cshtml"];
            };
        }
    }
}
