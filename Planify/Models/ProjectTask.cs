using System;

namespace Planify.Models
{
    public class ProjectTask : BaseModel<int>
    {
        public Priority Priority { get; set; }
        public required Project Project { get; set; }
        public DateTime LastUpdateUTC { get; set; }
    }

    public enum Priority
    {
        None, Low, Medium, High, Critical
    }

}
