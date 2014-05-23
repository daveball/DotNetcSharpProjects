using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class CustomCredentials : ClientCredentials
{
    public CustomCredentials()
    { }

    protected CustomCredentials(CustomCredentials cc)
        : base(cc)
    { }

    public override System.IdentityModel.Selectors.SecurityTokenManager CreateSecurityTokenManager()
    {
        return new CustomSecurityTokenManager(this);
    }

    protected override ClientCredentials CloneCore()
    {
        return new CustomCredentials(this);
    }
}