using System.Collections.Generic;

namespace Kanban.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all";
            string[] filters = FilterString.Split('-');
            CategoryId = filters[0];
            Due = filters[1];
            StatusId = filters[2];
         
        
        }
        public string FilterString { get; }
        public string CategoryId { get; }
        public string Due { get; }
        public string StatusId { get; }
        public string PointsId { get; } = "all";
        public string SprintId { get; } = "all";
        public bool HasCategory => CategoryId.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";
        public bool HasSprint =>  SprintId != "all";
        public bool HasPoints => PointsId != "all";

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string> {
                { "future", "Future" },
                { "past", "Past" },
                { "today", "Today" }
            };
        public bool IsPast => Due.ToLower() == "past";
        public bool IsFuture => Due.ToLower() == "future";
        public bool IsToday => Due.ToLower() == "today";
    }
}
