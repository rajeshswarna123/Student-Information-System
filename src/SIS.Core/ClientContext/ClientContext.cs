﻿using SIS.Models;
using System;

namespace SIS.Core.ClientContext
{
    public class ClientContext : IClientContext
    {
        public UserProfile UserInfo { get; set; }

        public string SessionId { get; set; }
        
        public DateTime? TokenExpiry { get; set; }
    }
}
