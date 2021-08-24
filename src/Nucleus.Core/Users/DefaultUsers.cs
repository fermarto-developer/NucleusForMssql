using System;
using System.Globalization;
using System.Collections.Generic;

namespace Nucleus.Core.Users
{
    public class DefaultUsers
    {
        public static List<User> All()
        {
            return new List<User>
            {
                Admin,
                Member,
                TestAdmin
            };
        }

        public static readonly User Admin = new User
        {
            Id = new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"),
            UserName = AdminUserName,
            Email = AdminUserEmail,
            EmailConfirmed = true,
            NormalizedEmail = AdminUserEmail.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            NormalizedUserName = AdminUserName.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            AccessFailedCount = 5,
            PasswordHash = PasswordHashFor123Qwe
        };

        public static readonly User Member = new User
        {
            Id = new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"),
            UserName = MemberUserName,
            Email = MemberUserEmail,
            EmailConfirmed = true,
            NormalizedEmail = MemberUserEmail.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            NormalizedUserName = MemberUserName.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            AccessFailedCount = 5,
            PasswordHash = PasswordHashFor123Qwe
        };

        public static readonly User TestAdmin = new User
        {
            Id = new Guid("4b6d9e45-626d-489a-a8cf-d32d36583af4"),
            UserName = TestAdminUserName,
            Email = TestAdminUserEmail,
            EmailConfirmed = true,
            NormalizedEmail = TestAdminUserEmail.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            NormalizedUserName = TestAdminUserName.ToUpper(CultureInfo.GetCultureInfo("en_US")),
            AccessFailedCount = 5,
            PasswordHash = PasswordHashFor123Qwe
        };

        private const string AdminUserName = "admin";
        private const string AdminUserEmail = "admin@mail.com";
        private const string PasswordHashFor123Qwe = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw=="; //123qwe
        private const string MemberUserName = "memberuser";
        private const string MemberUserEmail = "memberuser@mail.com";
        private const string TestAdminUserName = "testadmin";
        private const string TestAdminUserEmail = "testadmin@mail.com";
    }
}
