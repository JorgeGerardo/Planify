﻿namespace Planify.Services
{
    public static class PolicyNames
    {
        //[combinated]
        public const string MinimumRh = "Rh_RhAdmin_Admin_SA";
        public const string MinimumRhAdmin = "SA_Admin_RHADMIN";
        public const string MinimumAdmin = "SAorAdmin";
        public const string MinimumRhAdminOrViewer = "Viewer_Admin_SA";
        public const string MinimumAdminOrViewer = "Admin_SA_Viewer";

        //[individual]
        public const string SA = "sa";
        public const string Admin = "admin";
        public const string Manager = "manager";
        public const string RhAdmin = "rh-admin";
        public const string Rh = "rh";
        public const string Viewer = "viewer";
    }
}
