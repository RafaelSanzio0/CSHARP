using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Security
{
    public class TokenConfigurations
    {
        public string Audience { get; set; } // publico
        public string Issuer { get; set; } // emissor
        public int Seconds { get; set; }

    }
}
