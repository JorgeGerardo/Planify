using System;
using System.Collections.Generic;

namespace Planify.Models
{
    public class ProjectTask : BaseModel<int>
    {
        //TODO: Creo que no se debería poder cambiar la tarea a asignarla a otro proyecto
        // tampoco la fecha de creación
        public Project? Project { get; set; }
        public int ProjectId { get; set; }
        public DateTime? LastUpdateUTC { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public bool IsCompleted { get; set; } = false;
        public required string Description { get; set; }

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

    public class ProjectTaskCreateDTO
    {
        public int ProjectId { get; set; }

        public required Priority Priority { get; set; }

        //Dates:
        public DateTime? StartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }

        public required string Description { get; set; }

        public ICollection<Employee>? Employees { get; set; } = new List<Employee>();
    }


    public class ProjectTaskUpdateDTO
    {
        
    }

}
