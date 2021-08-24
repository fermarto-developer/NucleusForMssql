using System;
using System.Collections.Generic;
using System.Globalization;

namespace Nucleus.Core.Roles
{
    public static class DefaultRoles
    {
        public static List<Role> All()
        {
            return new List<Role>
            {
                Admin,
                Member
            };
        }

        public static readonly Role Admin = new Role
        {
            Id = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
            Name = RoleNameForAdmin,
            NormalizedName = RoleNameForAdmin.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            IsSystemDefault = true
        };

        public static readonly Role Member = new Role
        {
            Id = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"),
            Name = RoleNameForMember,
            NormalizedName = RoleNameForMember.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            IsSystemDefault = true
        };

        private const string RoleNameForAdmin = "Admin";
        private const string RoleNameForMember = "Member";
    }
}
