using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for Class2
/// </summary>
public class CustomSecurityTokenManager : ClientCredentialsSecurityTokenManager
{
    public CustomSecurityTokenManager(CustomCredentials cred)
        : base(cred)
    { }

    public override System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.IdentityModel.Selectors.SecurityTokenVersion version)
    {
        return new CustomTokenSerializer(System.ServiceModel.Security.SecurityVersion.WSSecurity11);
    }
}