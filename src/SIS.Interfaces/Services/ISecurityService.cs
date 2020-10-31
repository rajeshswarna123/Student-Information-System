using SIS.Core.ClientContext;
using SIS.Models;

namespace SIS.Interfaces.Services
{
    public interface ISecurityService
    {
        UserProfile Login(string email, string password);
    }
}
