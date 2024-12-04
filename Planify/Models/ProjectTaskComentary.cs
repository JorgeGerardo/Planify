using System;
using System.ComponentModel.DataAnnotations;

namespace Planify.Models
{
    public class ProjectTaskComentary : DbBaseModel<int>
    {
        public ProjectTask? ProjectTask { get; set; }
        public int ProjectTaskId { get; set; }

        public Employee? Author { get; set; }
        public int EmployeeId { get; set; }

        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public TimeOnly Time { get; set; } = TimeOnly.FromDateTime(DateTime.UtcNow);

        [MaxLength(255)]
        [MinLength(1)]
        public required string Comentary { get; set; }
    }
}
