using System;
using Microsoft.AspNetCore.Identity;

namespace NoterDonut.DATA.Entities
{
    public class AppUserRole: IdentityUserRole<int>
    {
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}