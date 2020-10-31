using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Core.ClientContext
{
    public class UserProfile
    {
        public long ID { get; set; }

        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Token { get; set; }
    }
}
