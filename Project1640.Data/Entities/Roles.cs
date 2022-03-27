using Microsoft.AspNetCore.Identity;
using System;

namespace Project1640.Data.Entities
{
    public class Roles : IdentityRole<Guid>
    {
        public const string Staff = "STAFF";
        public const string Admin = "ADMIN";
    }
}
