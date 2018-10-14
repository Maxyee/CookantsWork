using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using CookantsEntity.Model;
using CookantsRepository.Repository;
using CookantsService.Services;

namespace CoockantsWeb.Filters
{
    public class JwtAuthenticationAttribute : Attribute, IAuthenticationFilter
    {
        public string Realm { get; set; }
        public bool AllowMultiple => false;
        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            string controllerName = context.ActionContext.ControllerContext.ControllerDescriptor.ControllerName;
            string actionName = context.ActionContext.ActionDescriptor.ActionName;
            string Url = context.Request.RequestUri.AbsoluteUri;
            var request = context.Request;
            var authorization = request.Headers.Authorization;
            if (authorization == null || authorization.Scheme != "Bearer")
                return;

            if (string.IsNullOrEmpty(authorization.Parameter))
            {
                context.ErrorResult = new AuthenticationFailureResult("Missing Jwt Token", request);
                return;
            }

            var token = authorization.Parameter;
            string username;
            string roleId;
            string userId;
            if (!ValidateToken(token, out username, out roleId,out userId))
                return;
            // role permission
            //ISecurityActionService actionService=new SecurityActionService(new SecurityActionRepository(),new SecurityPernissionRepository());
            //if (actionService.CheckPermission(
            //        new SecurityAction() {ApiController = controllerName, ActionName = actionName},
            //        Convert.ToInt32(roleId)))
            //    return;
            var principal = await AuthenticateJwtToken(username,roleId,userId);

            if (principal == null)
                context.ErrorResult = new AuthenticationFailureResult("Invalid token", request);

            else
                context.Principal = principal;
        }
        private static bool ValidateToken(string token, out string username, out string roleId,out string userId)
        {
            username = null;
            roleId = null;
            userId = null;

            var simplePrinciple = JwtTokenProviders.GetPrincipal(token);
            var identity = simplePrinciple.Identity as ClaimsIdentity;

            if (identity == null)
                return false;

            if (!identity.IsAuthenticated)
                return false;

            username = identity.FindFirst(ClaimTypes.Name).Value;
            roleId = identity.FindFirst(ClaimTypes.Role).Value;
            userId = identity.FindFirst(ClaimTypes.Sid).Value;

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(roleId) && string.IsNullOrEmpty(userId))
                return false;

            // More validate to check whether username exists in system

            ISecurityUserService securityUserService = new SecurityUserService(new UserPointRepository(), new SecurityUserRepository(),new AddressRepository());
            return securityUserService.IsExistUserName(new SecurityUser() {Email = username});

        }

        protected Task<IPrincipal> AuthenticateJwtToken(string username,string roleId,string userId)
        { 
                // based on username to get more information from database in order to build local identity
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, roleId),
                    new Claim(ClaimTypes.Sid, userId)
                    // Add more claims if needed: Roles, ...
                };
                var identity = new ClaimsIdentity(claims, "Jwt");
                IPrincipal user = new ClaimsPrincipal(identity);
                return Task.FromResult(user);
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            Challenge(context);
            return Task.FromResult(0);
        }

        private void Challenge(HttpAuthenticationChallengeContext context)
        {
            string parameter = null;

            if (!string.IsNullOrEmpty(Realm))
                parameter = "realm=\"" + Realm + "\"";

            context.ChallengeWith("Bearer", parameter);
        }
    }
}
