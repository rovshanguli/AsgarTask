using Microsoft.AspNetCore.Http;
using ServiceLayer.DTOs.CurrentUser;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CurrentUser : ICurrentUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public CurrentUserDto GetCurrentUser()
        {
            var user = _httpContextAccessor.HttpContext.User;
            var userId = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
            var userRoles = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value;

            CurrentUserDto currentUser = new CurrentUserDto
            {
                Id = userId,
                Roles = userRoles
            };

            return currentUser;

        }
    }
}
