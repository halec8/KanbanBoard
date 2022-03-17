using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kanban.Models
{
    public class KanbanContext : DbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options)
            : base(options) { }

        public DbSet<KanbanBoard> Kanbans { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<SprintNumber> SprintNumber { get; set; }
        public DbSet<Point> Points { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Work" },
                new Category { CategoryId = "home", Name = "Home" },
                new Category { CategoryId = "ex", Name = "Exercise" },
                new Category { CategoryId = "shop", Name = "Shopping" },
                new Category { CategoryId = "call", Name = "Contact" }
            );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "todo", Name = "To do" },
                new Status { StatusId = "inprogress", Name = "In Progress" },
                new Status { StatusId = "qa", Name = "Quality Assurance (QA)"},
                new Status { StatusId = "done", Name = "Done"}
               
            );
            
            modelBuilder.Entity<Point>().HasData(
                new Point { PointId = "first", PointAmount = "25" },
                new Point { PointId = "second", PointAmount = "50" },
                new Point { PointId = "third", PointAmount = "75" },
                new Point { PointId = "fourth", PointAmount = "100" }
                );

            modelBuilder.Entity<SprintNumber>().HasData(
                new SprintNumber { SprintNumberId = "weekone", Name = "Sprint 1"},
                new SprintNumber { SprintNumberId = "weektwo", Name = "Sprint 2" },
                new SprintNumber { SprintNumberId = "weekthree", Name = "Sprint 3" },
                new SprintNumber { SprintNumberId = "weekfour", Name = "Sprint 4" },
                new SprintNumber { SprintNumberId = "weekfive", Name = "Sprint 5" },
                new SprintNumber { SprintNumberId = "weeksix", Name = "Sprint 6" },
                new SprintNumber { SprintNumberId = "weekseven", Name = "Sprint 7" },
                new SprintNumber { SprintNumberId = "weekeight", Name = "Sprint 8" },
                new SprintNumber { SprintNumberId = "weeknine", Name = "Sprint 9" },
                new SprintNumber { SprintNumberId = "weekten", Name = "Sprint 10" },
                new SprintNumber { SprintNumberId = "weekeleven", Name = "Sprint 11" },
                new SprintNumber { SprintNumberId = "weektwelve", Name = "Sprint 12" },
                new SprintNumber { SprintNumberId = "weekthirteen", Name = "Sprint 13" },
                new SprintNumber { SprintNumberId = "weekfourteen", Name = "Sprint 14" },
                new SprintNumber { SprintNumberId = "weekfifteen", Name = "Sprint 15" },
                new SprintNumber { SprintNumberId = "weeksixteen", Name = "Sprint 16" },
                new SprintNumber { SprintNumberId = "weekseventeen", Name = "Sprint 17" },
                new SprintNumber { SprintNumberId = "weekeighteen", Name = "Sprint 18" },
                new SprintNumber { SprintNumberId = "weeknineteen", Name = "Sprint 19" },
                new SprintNumber { SprintNumberId = "weektwenty", Name = "Sprint 20" },
                new SprintNumber { SprintNumberId = "weektwentyone", Name = "Sprint 21" },
                new SprintNumber { SprintNumberId = "weektwentytwo", Name = "Sprint 22" },
                new SprintNumber { SprintNumberId = "weektwentythree", Name = "Sprint 23" },
                new SprintNumber { SprintNumberId = "weektwentyfour", Name = "Sprint 24" },
                new SprintNumber { SprintNumberId = "weektwentyfive", Name = "Sprint 25" },
                new SprintNumber { SprintNumberId = "weektwentysix", Name = "Sprint 26" },
                new SprintNumber { SprintNumberId = "weektwentyseven", Name = "Sprint 27" },
                new SprintNumber { SprintNumberId = "weektwentyeight", Name = "Sprint 28" },
                new SprintNumber { SprintNumberId = "weektwentynine", Name = "Sprint 29" },
                new SprintNumber { SprintNumberId = "weekthirty", Name = "Sprint 30" },
                new SprintNumber { SprintNumberId = "weekthirtyone", Name = "Sprint 31" },
                new SprintNumber { SprintNumberId = "weekthirtytwo", Name = "Sprint 32" },
                new SprintNumber { SprintNumberId = "weekthirtythree", Name = "Sprint 33" },
                new SprintNumber { SprintNumberId = "weekthirtyfour", Name = "Sprint 34" },
                new SprintNumber { SprintNumberId = "weekthirtyfive", Name = "Sprint 35" },
                new SprintNumber { SprintNumberId = "weekthirtysix", Name = "Sprint 36" },
                new SprintNumber { SprintNumberId = "weekthirtyseven", Name = "Sprint 37" },
                new SprintNumber { SprintNumberId = "weekthirtyeight", Name = "Sprint 38" },
                new SprintNumber { SprintNumberId = "weekthirtynine", Name = "Sprint 39" },
                new SprintNumber { SprintNumberId = "weekforty", Name = "Sprint 40" },
                new SprintNumber { SprintNumberId = "weekfortyone", Name = "Sprint 41" },
                new SprintNumber { SprintNumberId = "weekfortytwo", Name = "Sprint 42" },
                new SprintNumber { SprintNumberId = "weekfortythree", Name = "Sprint 43" },
                new SprintNumber { SprintNumberId = "weekfortyfour", Name = "Sprint 44" },
                new SprintNumber { SprintNumberId = "weekfortyfive", Name = "Sprint 45" },
                new SprintNumber { SprintNumberId = "weekfortysix", Name = "Sprint 46" },
                new SprintNumber { SprintNumberId = "weekfortyseven", Name = "Sprint 47" },
                new SprintNumber { SprintNumberId = "weekfortyeight", Name = "Sprint 48" },
                new SprintNumber { SprintNumberId = "weekfortynine", Name = "Sprint 49" },
                new SprintNumber { SprintNumberId = "weekfifty", Name = "Sprint 50" },
                new SprintNumber { SprintNumberId = "weekfiftyone", Name = "Sprint 51" },
                new SprintNumber { SprintNumberId = "weekfiftytwo", Name = "Sprint 52" }
            );
        }
    }
}
