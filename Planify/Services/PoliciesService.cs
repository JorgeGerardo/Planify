using Microsoft.AspNetCore.Authorization;

namespace Planify.Services
{
    public static class PoliciesService
    {
        // [rh-admin]
        public static AuthorizationPolicy GetRhAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("recursos-humanos", "admin")
                .RequireClaim("edit", "delete", "read", "create")
                .RequireAuthenticatedUser()
                .Build();


        // [pj-manager]
        public static AuthorizationPolicy GetPjManager() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("manager")
                .RequireClaim("edit", "delete", "read", "create")
                .RequireAuthenticatedUser()
                .Build();


        //[rh]
        public static AuthorizationPolicy GetHumanResourcesPolicy() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("recursos-humanos")
                .RequireClaim("create", "read", "edit", "delete")
                .RequireAuthenticatedUser()
                .Build();


        //[sa]
        public static AuthorizationPolicy GetSystemAdminPolicy() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("sa")
                .RequireAuthenticatedUser()
                .Build();


        //[viewer]
        public static AuthorizationPolicy GetViewerPolicy() =>
            new AuthorizationPolicyBuilder()
                .RequireClaim("read")
                .RequireAuthenticatedUser()
                .Build();


    }
}
