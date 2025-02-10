using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    //TODO: Fix the name
    public class ProjectTaskComentary : DbBaseModel<int>
    {
        [JsonIgnore]
        public ProjectTask? ProjectTask { get; set; }
        public required int ProjectTaskId { get; set; }
        [JsonIgnore]
        public Employee? Author { get; set; }
        public required int EmployeeId { get; set; }

        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public TimeOnly Time { get; set; } = TimeOnly.FromDateTime(DateTime.UtcNow);

        [MaxLength(255)]
        [MinLength(1)]
        public required string Comentary { get; set; }
    }

    //TODO: Fix the name
    public class ProjectTaskComentaryCreateDTO
    {
        [MaxLength(255, ErrorMessage = "Los comentarios tienen un límite máximo de 255 caracteres.")]
        [MinLength(1, ErrorMessage = "No puede enviar un comentario vacío.")]
        public required string Comentary { get; set; }
    }

    public class CommentaryView
    {
        public required int Id { get; set; }
        public required int ProjectTaskId { get; set; }
        public required DateOnly Date { get; set; }
        public required TimeOnly Time { get; set; }
        public required string Commentary { get; set; }
        public required DateTime CreateDateUtc { get; set; }
        public required string AuthorName { get; set; }
        public required int EmployeeId { get; set; }
        public required string? UrlProfileImage { get; set; }
    }
}
