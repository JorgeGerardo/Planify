using System.ComponentModel.DataAnnotations;
using System;

namespace Planify.Models
{
    public abstract class BaseModel<TId>
    {
        public TId? Id { get; set; }
        public required string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedTimeUTC { get; set; }

        [ConcurrencyCheck]
        public DateTime LastUpdatedUTC { get; set; }
    }
}
