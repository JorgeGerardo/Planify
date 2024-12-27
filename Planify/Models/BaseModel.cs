using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public abstract class BaseModel<TId> : DbBaseModel<TId>
    {
        [JsonPropertyOrder(-2)]
        public required string Name { get; set; }
    }

    public abstract class DbBaseModel<TId>
    {
        [JsonPropertyOrder(-1)]

        public TId? Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedTimeUTC { get; set; }

        [ConcurrencyCheck]
        public DateTime? LastUpdatedUTC { get; set; }
        public DateTime? CreateDateUTC { get; set; } = DateTime.UtcNow;
    }
}
