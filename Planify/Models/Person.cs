using System;
using System.ComponentModel.DataAnnotations;

namespace Planify.Models
{
    public class Person : BaseModel<int>
    {
        public DateOnly BornDate { get; set; }
        public required string LastNames { get; set; }
        public required string City { get; set; }
        public required string Sate { get; set; }
        public required string Country { get; set; }
        public Employee? Employee { get; set; }

        //[Phone]
        [MaxLength(12)]
        [MinLength(10)]
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

        //[Phone]
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

        //[Phone]
        public string? PhoneNumber { get; set; }

    }

}
