using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CustomUserManagment.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CustomUserManagmentUser class
public class CustomUserManagmentUser : IdentityUser
{
    public string? FullName { get; set; }
    public byte[]? Picture { get; set; }

}

