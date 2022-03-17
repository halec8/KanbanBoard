using System;
using System.ComponentModel.DataAnnotations;


namespace Kanban.Models
{
    public class KanbanBoard
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status Status { get; set; }


        public string PointId { get; set; }
        public Point Points { get; set; }


        public string SprintNumberId { get; set; }
        public SprintNumber SprintNumbers { get; set; }

    

        public bool Overdue =>
            StatusId == "open" && DueDate < DateTime.Today;
    }
}
