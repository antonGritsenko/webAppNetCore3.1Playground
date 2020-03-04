using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace webAppNetCore31SPAIS4.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>https://docs.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-3.1#customize-the-model</remarks>
    public class ApplicationRole : IdentityRole<string>
    {
    }
}
