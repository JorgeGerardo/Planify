using System;
using System.ComponentModel.DataAnnotations;

namespace Planify.Models
{
    public class Person : BaseModel<int>
    {
        public DateOnly BornDate { get; set; }
        public required string FirstNames { get; set; }
        public required string LastNames { get; set; }
        public required string City { get; set; }
        public required string Sate { get; set; }
        public required string Country { get; set; }
        public Employee? Employee { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }

    }

    public class PersonDTO
    {
        public required string Name { get; set; }
        public DateOnly BornDate { get; set; }
        public required string FirstNames { get; set; }
        public required string LastNames { get; set; }
        public required string City { get; set; }
        public required string Sate { get; set; }
        public required string Country { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }

    }
}
