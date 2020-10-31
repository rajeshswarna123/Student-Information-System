using SIS.Core.ClientContext;

namespace SIS.Interfaces.Services
{
    public interface ISecurityService
    {
        UserProfile Login(string email, string password);
    }
}
