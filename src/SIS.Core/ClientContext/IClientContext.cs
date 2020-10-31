using SIS.Models;
using System;

namespace SIS.Core.ClientContext
{
    public interface IClientContext
    {
        UserProfile UserInfo { get; set; }

        string SessionId { get; set; }

        DateTime? TokenExpiry { get; set; }
    }
}
