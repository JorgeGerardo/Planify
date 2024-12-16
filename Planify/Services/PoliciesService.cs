using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Planify.Services
{
    // [alone]
    public static partial class PoliciesService
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
                .RequireAuthenticatedUser()
                .Build();


        // [pj-manager]
        public static AuthorizationPolicy GetPjManager() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("manager")
                .RequireAuthenticatedUser()
                .Build();



        // [rh-admin]
        public static AuthorizationPolicy GetRhAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("rh-admin")
                .RequireAuthenticatedUser()
                .Build();



        //[rh]
        public static AuthorizationPolicy GetHumanResources() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("rh")
                .RequireAuthenticatedUser()
                .Build();


        //[viewer]
        public static AuthorizationPolicy GetViewer() =>
            new AuthorizationPolicyBuilder()
                .RequireRole("viewer")
                .RequireAuthenticatedUser()
                .Build();

    }


    // [Combinated]
    public static partial class PoliciesService
    {
        public static AuthorizationPolicy GetMinimumAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    //TODO:Creo que se deberían eliminar los permisos y trabajar solo con roles

                    string[] validRoles =
                    { PolicyNames.SA, PolicyNames.Admin};

                    return IsClaimsMatch(validRoles, context.User.Claims);
                })
                .Build();

        public static AuthorizationPolicy GetMinimumRhAdmin() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    string[] validRoles =
                    { PolicyNames.RhAdmin, PolicyNames.Admin, PolicyNames.SA };

                    return IsClaimsMatch(validRoles, context.User.Claims);
                })
                .Build();

        public static AuthorizationPolicy GetMinimumRh() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    string[] validRoles =
                        {PolicyNames.Rh, PolicyNames.RhAdmin, PolicyNames.Admin, PolicyNames.SA };

                    return IsClaimsMatch(validRoles, context.User.Claims);
                })
                .Build();


        //With Viewer
        public static AuthorizationPolicy Get_MinimumAdmin_OrViewer() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    string[] validRoles =
                    { PolicyNames.Admin, PolicyNames.SA, PolicyNames.Viewer };

                    return IsClaimsMatch(validRoles, context.User.Claims);
                })
                .Build();

        public static AuthorizationPolicy Get_MinimumRhAdmin_OrViewer() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    string[] validRoles =
                    { PolicyNames.RhAdmin, PolicyNames.Admin, PolicyNames.SA, PolicyNames.Viewer };

                    return IsClaimsMatch(validRoles, context.User.Claims);
                })
                .Build();

        public static AuthorizationPolicy Get_MinimumRh_OrViewer() =>
            new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireAssertion(context =>
                {
                    string[] validRoles =
                    { PolicyNames.Rh, PolicyNames.RhAdmin, PolicyNames.Admin, PolicyNames.SA, PolicyNames.Viewer };

                    return IsClaimsMatch(validRoles, context.User.Claims);
                })
                .Build();

    }

    // [Tools]
    public static partial class PoliciesService
    {
        private static bool IsClaimsMatch(string[] validRoles, IEnumerable<Claim> claims) =>
            claims
            .Where(c => c.Type is ClaimTypes.Role)
            .Any(c => validRoles.Contains(c.Value));

    }


}
