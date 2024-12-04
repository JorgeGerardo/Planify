using System;
using System.Collections.Generic;

namespace Planify.Models
{
    public class ProjectTask : BaseModel<int>
    {
        //Nav properties
        public Project? Project { get; set; }
        public int ProjectId { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public bool IsCompleted { get; set; } = false;
        public required string Description { get; set; }
        public List<string> Comments { get; set; } = new List<string>();


        //Dates:
        public DateTime CreatedDateUTC { get; set; } = DateTime.UtcNow;
        public DateOnly StartDate { get; set; }
        public DateOnly EstimatedEndDate { get; set; }
        public TimeOnly? CompleteDate { get; set; }


        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public required Priority Priority { get; set; }

        public ICollection<ProjectTaskComentary> Comentaries { get; set; } = new List<ProjectTaskComentary>();

    }

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

    public class ProjectTaskCreateDTO
    {
        public required string Name { get; set; }
        public int ProjectId { get; set; }

        public required Priority Priority { get; set; }

        //Dates:
        public DateOnly StartDate { get; set; }
        public DateOnly EstimatedEndDate { get; set; }

        public required string Description { get; set; }

    }


    public class ProjectTaskUpdateDTO
    {
        public required string Name { get; set; }
        public required int ProjectId { get; set; }
        public required bool IsCompleted { get; set; }
        public string? Description { get; set; }

        public DateOnly? StartDate { get; set; }
        public DateOnly? EstimatedEndDate { get; set; }

        public TimeOnly? CompleteDate { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public Priority? Priority { get; set; }

    }

}
