﻿using System.Collections.Generic;

namespace Planify.Models
{
    public class Project : BaseModel<int>
    {
        public required Employee Manager { get; set; }
        public int ManagerId { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }

    public class ProjectDTO
    {
        public required string Name { get; set; }
        public int ManagerId { get; set; }
    }
}
