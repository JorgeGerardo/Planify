using System;
using System.Collections.Generic;

namespace Planify.Models
{
    public class ProjectTask : BaseModel<int>
    {
        public Priority Priority { get; set; }
        public required Project Project { get; set; }
        public DateTime LastUpdateUTC { get; set; }
        //TODO: Falta un ICollection<Employee>
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        // También falta un estado:
        //public bool IsCompleted { get; set; } = false;
        //Una fecha que indique cuándo se completo:
        //public TimeOnly? CompleteDate { get; set; } = null;
        //public string Description { get; set; } = string.Empty;
        //public DateTime CreatedDateUTC { get; set; } = DateTime.UtcNow;
        //public DateTime? StartDate { get; set; }
        //public DateTime? EstimatedEndDate { get; set; }

        //public TaskStatus Status { get; set; } = TaskStatus.Pending;
        //public required Employee AssignedBy { get; set; }
        //public List<string> Comments { get; set; } = new List<string>();
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
