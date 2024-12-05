using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class Person : BaseModel<int>
    {
        public DateOnly BornDate { get; set; }
        public required string LastNames { get; set; }
        public required string City { get; set; }
        public required string Sate { get; set; }
        public required string Country { get; set; }
        [JsonIgnore]
        public Employee? Employee { get; set; }

        [RegularExpression(@"^\+?[0-9]{10,15}$", ErrorMessage = "Invalid phone number format.")]
        public string? PhoneNumber { get; set; }

    }

    ///////////////////////////////// [Create DTO] ////////////////////////////////////////////////////
    public class PersonDTO
    {
        public required string Name { get; set; }
        public DateOnly BornDate { get; set; }
        public required string LastNames { get; set; }
        public required string City { get; set; }
        public required string Sate { get; set; }
        public required string Country { get; set; }

        [RegularExpression(@"^\+?[0-9]{10,15}$", ErrorMessage = "Invalid phone number format.")]
        public string? PhoneNumber { get; set; }

    }

    ///////////////////////////////// [Update DTO] ///////////////////////////////////////////////

    public class PersonUpdateDTO
    {
        public string? Name { get; set; }
        public DateOnly? BornDate { get; set; }
        public string? LastNames { get; set; }
        public string? City { get; set; }
        public string? Sate { get; set; }
        public string? Country { get; set; }

        [RegularExpression(@"^\+?[0-9]{10,15}$", ErrorMessage = "Invalid phone number format.")]
        public string? PhoneNumber { get; set; }

    }

}
