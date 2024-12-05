using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class ProjectTaskComentary : DbBaseModel<int>
    {
        [JsonIgnore]
        public ProjectTask? ProjectTask { get; set; }
        public int ProjectTaskId { get; set; }
        [JsonIgnore]
        public Employee? Author { get; set; }
        public int EmployeeId { get; set; }

        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public TimeOnly Time { get; set; } = TimeOnly.FromDateTime(DateTime.UtcNow);

        [MaxLength(255)]
        [MinLength(1)]
        public required string Comentary { get; set; }
    }
}
