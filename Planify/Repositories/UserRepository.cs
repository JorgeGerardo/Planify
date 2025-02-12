﻿using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class UserRepository : GenericRepository<User, int>
    {
        private string[] NavProperties =
            [nameof(User.Employee), nameof(User.Roles), nameof(User.Employee)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public UserRepository(ProjectContext context) : base(context) { }
    }
}
