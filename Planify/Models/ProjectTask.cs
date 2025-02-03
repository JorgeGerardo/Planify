using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class ProjectTask : BaseModel<int>
    {
        //Nav properties
        [JsonIgnore]
        public Project? Project { get; set; }
        public int ProjectId { get; set; }
        [JsonIgnore]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public bool IsCompleted { get; set; } = false;
        public required string Description { get; set; }


        //Dates:
        public DateTime CreatedDateUTC { get; set; } = DateTime.UtcNow;
        //TODO: Maybe be required:
        public DateOnly StartDate { get; set; }

        //TODO: Change DateOnly to DateTime
        public DateOnly EstimatedEndDate { get; set; }
        public TimeOnly? CompleteDate { get; set; }


        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public required Priority Priority { get; set; }

        [JsonIgnore]
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
        [MaxLength(30, ErrorMessage = "El límite para el nombre es de 30 caracteres.")]
        [MinLength(5, ErrorMessage = "El nombre de tener al menos 5 caracteres.")]
        public required string Name { get; set; }
        public int ProjectId { get; set; }

        public required Priority Priority { get; set; }

        //Dates:
        public DateOnly StartDate { get; set; }
        public DateOnly EstimatedEndDate { get; set; }

        [MaxLength(255, ErrorMessage = "La descripción de la tarea no puede exceder el límite de 255 caracteres.")]
        [MinLength(20, ErrorMessage = "La descripción debe tener al menos 20 caracteres.")]
        public required string Description { get; set; }

    }


    public class ProjectTaskUpdateDTO
    {
        [MaxLength(30, ErrorMessage = "El límite para el nombre es de 30 caracteres.")]
        [MinLength(5, ErrorMessage = "El nombre de tener al menos 5 caracteres.")]
        public string? Name { get; set; }
        public required int ProjectId { get; set; }
        public bool? IsCompleted { get; set; }
        [MaxLength(255, ErrorMessage = "La descripción de la tarea no puede exceder el límite de 255 caracteres.")]
        [MinLength(20, ErrorMessage = "La descripción debe tener al menos 20 caracteres." )]
        public string? Description { get; set; }

        public DateOnly? StartDate { get; set; }
        public DateOnly? EstimatedEndDate { get; set; }

        public TimeOnly? CompleteDate { get; set; }

        public TaskStatus? Status { get; set; }
        public Priority? Priority { get; set; }

    }

}
