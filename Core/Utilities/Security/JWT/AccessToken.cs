using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public int Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
