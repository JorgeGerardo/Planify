using System;
using System.Collections.Generic;

namespace Planify.Models
{
    public class ProjectTask : BaseModel<int>
    {
        public required Project Project { get; set; }
        public DateTime? LastUpdateUTC { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public bool IsCompleted { get; set; } = false;
        public string Description { get; set; } = "¡Sin descripción!";

        //Dates:
        public DateTime CreatedDateUTC { get; set; } = DateTime.UtcNow;
        public DateTime? StartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public TimeOnly? CompleteDate { get; set; }


        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public required Priority Priority { get; set; }

        public List<string> Comments { get; set; } = new List<string>();
    }

    //TODO: Agrega la conversión en FLUENT API
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed,
        Blocked,
        OnHold
    }

    public enum Priority
    {
        None, Low, Medium, High, Critical
    }

}
