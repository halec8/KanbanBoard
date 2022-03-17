using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kanban.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private KanbanContext context;
        public HomeController(KanbanContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            //store current filters and data needed for filter drop downs in ToDoViewModel
            KanbanViewModel model = new KanbanViewModel();

            var filters = new Filters(id);

            model.Filters = new Filters(id);
            model.Categories = context.Categories.ToList();
            model.Statuses = context.Statuses.ToList();
            model.SprintNumbers = context.SprintNumber.ToList();
            model.Points = context.Points.ToList();
            model.DueFilters = Filters.DueFilterValues;


            // get ToDo objects from database based on current filters
            IQueryable<KanbanBoard> query = context.Kanbans
                .Include(t => t.Category)
                .Include(t => t.Status)
                .Include(t => t.SprintNumbers)
                .Include(t => t.Points);

            if (filters.HasCategory)
            {
                query = query.Where(t => t.CategoryId == filters.CategoryId);
            }

            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }
            if (filters.HasPoints)
            {
                query = query.Where(t => t.PointId == filters.PointsId);
            }
            if (filters.HasSprint)
            {
                query = query.Where(t => t.SprintNumberId == filters.SprintId);
            }

            if (filters.HasDue)
            {
                var today = DateTime.Today;
                if (filters.IsPast)
                    query = query.Where(t => t.DueDate < today);
                else if (filters.IsFuture)
                    query = query.Where(t => t.DueDate > today);
                else if (filters.IsToday)
                    query = query.Where(t => t.DueDate == today);
            }
            var tasks = query.OrderBy(t => t.DueDate).ToList();

            model.Tasks = tasks;
            return View(model);
        }

        public IActionResult Add()
        {
            KanbanViewModel model = new KanbanViewModel();
            model.Categories = context.Categories.ToList();
            model.Statuses = context.Statuses.ToList();
            model.SprintNumbers = context.SprintNumber.ToList();
            model.Points = context.Points.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(KanbanViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Kanbans.Add(model.CurrentTask);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                model.Categories = context.Categories.ToList();
                model.Statuses = context.Statuses.ToList();
                model.SprintNumbers = context.SprintNumber.ToList();
                model.Points = context.Points.ToList();
                
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, KanbanBoard selected)
        {
            if (selected.StatusId == null)
            {
                context.Kanbans.Remove(selected);
            }
            else
            {
                string newStatusId = selected.StatusId;
                selected = context.Kanbans.Find(selected.Id);
                selected.StatusId = newStatusId;
                context.Kanbans.Update(selected);
            }
            context.SaveChanges();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}