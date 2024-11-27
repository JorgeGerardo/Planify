using System.ComponentModel.DataAnnotations;
using System;
using System.Security.Cryptography;

namespace Planify.Models
{
    public abstract class BaseModel<TId> : DbBaseModel<TId>
    {
        public required string Name { get; set; }
    }

    public abstract class DbBaseModel<TId>
    {
        public TId? Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedTimeUTC { get; set; }

        [ConcurrencyCheck]
        public DateTime LastUpdatedUTC { get; set; }
    }
}
