using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Security.Claims;

namespace Planify.Services
{
    public static class PoliciesService
    {
        //[sa]
        public static AuthorizationPolicy GetSA() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("sa")
                .RequireAuthenticatedUser()
                .Build();


        //[admin]
        public static AuthorizationPolicy GetAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("admin")
                .RequireClaim("edit", "true")
                .RequireClaim("soft-delete", "true")
                .RequireClaim("read", "true")
                .RequireClaim("create", "true")
                .RequireClaim("restore", "true")
                .RequireAuthenticatedUser()
                .Build();


        // [pj-manager]
        public static AuthorizationPolicy GetPjManager() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("manager")
                .RequireClaim("edit", "true")
                .RequireClaim("soft-delete", "true")
                .RequireClaim("read", "true")
                .RequireClaim("create", "true")
                .RequireAuthenticatedUser()
                .Build();



        // [rh-admin]
        public static AuthorizationPolicy GetRhAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("rh-admin")
                .RequireClaim("edit", "true")
                .RequireClaim("soft-delete", "true")
                .RequireClaim("read", "true")
                .RequireClaim("create", "true")
                .RequireClaim("restore", "true")
                .RequireAuthenticatedUser()
                .Build();



        //[rh]
        public static AuthorizationPolicy GetHumanResources() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("rh")
                .RequireClaim("create", "true")
                .RequireClaim("read", "true")
                .RequireAuthenticatedUser()
                .Build();


        //[viewer]
        public static AuthorizationPolicy GetViewer() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("viewer")
                .RequireClaim("read", "true")
                .RequireAuthenticatedUser()
                .Build();

        // [Combinated]
        public static AuthorizationPolicy GetSAorAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    //TODO:Creo que se deberían eliminar los permisos y trabajar solo con roles
                    if (context.User.HasClaim(c => c.Type is ClaimTypes.Role && c.Value is PolicyNames.SA))
                        return true;
                    return IsAdmin(context);
                })
                .Build();

        public static AuthorizationPolicy GetRhAdmin_Admin_SA() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    string[] validRoles =
                    { PolicyNames.RhAdmin, PolicyNames.Admin, PolicyNames.SA };

                    return context.User.Claims
                        .Where(c => c.Type is ClaimTypes.Role)
                        .Any(c => validRoles.Contains(c.Value));
                })
                .Build();

        public static AuthorizationPolicy Get_Rh_RhAdmin_Admin_SA() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    string[] validRoles =
                        { PolicyNames.SA, PolicyNames.Rh, PolicyNames.Admin, PolicyNames.RhAdmin };

                    return context.User.Claims
                    .Where(c => c.Type is ClaimTypes.Role)
                    .Any(c => validRoles.Contains(c.Value));
                })
                .Build();

        private static bool IsAdmin(AuthorizationHandlerContext context)
        {
            if (!context.User.HasClaim(c => c.Type is ClaimTypes.Role && c.Value is PolicyNames.Admin))
                return false;

            if (context.User.HasClaim(c => c.Type is "edit" && c.Value is "true") &&
                context.User.HasClaim(c => c.Type is "soft-delete" && c.Value is "true") &&
                context.User.HasClaim(c => c.Type is "read" && c.Value is "true") &&
                context.User.HasClaim(c => c.Type is "create" && c.Value is "true") &&
                context.User.HasClaim(c => c.Type is "restore" && c.Value is "true"))
                return true;

            return false;
        }

    }
}
