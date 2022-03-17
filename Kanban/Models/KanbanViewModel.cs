using System.Collections.Generic;

namespace Kanban.Models
{
    public class KanbanViewModel
    {
    
            public KanbanViewModel()
            {
                CurrentTask = new KanbanBoard();
            }
            public Filters Filters { get; set; }
            public List<Status> Statuses { get; set; }
            public List<Category> Categories { get; set; }
            public List<SprintNumber> SprintNumbers { get; set; }
            public List<Point> Points { get; set; }
            public Dictionary<string, string> DueFilters { get; set; }

            public List<KanbanBoard> Tasks { get; set; }

            public KanbanBoard CurrentTask { get; set; }  //used for Add
        }
}

