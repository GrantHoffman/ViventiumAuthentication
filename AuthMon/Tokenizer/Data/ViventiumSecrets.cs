using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Tokenizer.Data
{
    public class ViventiumSecrets

    {
        public const string SECRET = "wsdfskjzhfkl24235234";
        public static string HiddenKey = "";
        private RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

        private SecurityTokenDescriptor token = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(),
            Expires = DateTime.UtcNow.AddDays(30),
            SigningCredentials = new SigningCredentials(null, "pscoppe")
        };

        private byte[] KeyArr = new byte[256];

        public ViventiumSecrets()
        {
        }
    }

    public class ViventiumApi
    {
        public string Crawler { get; set; }
    }
}