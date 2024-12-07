using Microsoft.AspNetCore.Authorization;

namespace Planify.Services
{
    public static class PoliciesService
    {

        public static AuthorizationPolicy GetRhAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireClaim("finanzas", "recursos-humanos", "admin", "edit", "delete", "read", "create")
                .Build();


        public static AuthorizationPolicy GetHumanResources() =>
            new AuthorizationPolicyBuilder()
                .RequireClaim("recursos-humanos", "create", "read", "edit")
                .Build();


        public static AuthorizationPolicy GetSystemAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("sa")
                .Build();

        public static AuthorizationPolicy GetViewerAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("read")
                .Build();

    }
}
