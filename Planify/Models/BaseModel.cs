using System.ComponentModel.DataAnnotations;
using System;

namespace Planify.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedTimeUTC { get; set; }

        [ConcurrencyCheck]
        public DateTime LastUpdatedUTC { get; set; }
    }
}
