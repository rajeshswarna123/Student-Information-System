using Microsoft.AspNetCore.Mvc;
using SIS.Core.ClientContext;
using SIS.Interfaces.Services;
using SIS.Models;

namespace SIS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityService _securityService;

        public SecurityController(ISecurityService securityService)
        {
            this._securityService = securityService;
        }

        [HttpPost]
        [Route("signin")]
        public UserProfile Login(LoginRequest loginRequest)
        {
            return _securityService.Login(loginRequest.Email, loginRequest.Password);
        }
    }
}
