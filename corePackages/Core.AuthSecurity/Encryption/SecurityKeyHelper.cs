﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Core.AuthSecurity.Encryption;

public class SecurityKeyHelper
{
    public static SecurityKey CreateSecurityKey(string securityKey)
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
    }
}