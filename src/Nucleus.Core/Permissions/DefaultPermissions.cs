using System;
using System.Collections.Generic;

namespace Nucleus.Core.Permissions
{
    public class DefaultPermissions
    {
        public static List<Permission> All()
        {
            return new List<Permission>
            {
                AdministrationAccess,
                MemberAccess,
                UserRead,
                UserCreate,
                UserUpdate,
                UserDelete,
                RoleRead,
                RoleCreate,
                RoleUpdate,
                RoleDelete

                // add your permission to list
            };
        }

        public static readonly Permission AdministrationAccess = new Permission
        {
            DisplayName = "Administration access",
            Name = PermissionNameForAdministration,
            Id = new Guid("2a1ccb43-fa4f-48ce-b601-d3ab4d611b32"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission MemberAccess = new Permission
        {
            DisplayName = "Member access",
            Name = PermissionNameForMemberAccess,
            Id = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission UserRead = new Permission
        {
            DisplayName = "User read",
            Name = PermissionNameForUserRead,
            Id = new Guid("86d804bd-d022-49a5-821a-d2240478aac4"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission UserCreate = new Permission
        {
            DisplayName = "User create",
            Name = PermissionNameForUserCreate,
            Id = new Guid("8f3de3ec-3851-4ba9-887a-2119f18ae744"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission UserUpdate = new Permission
        {
            DisplayName = "User update",
            Name = PermissionNameForUserUpdate,
            Id = new Guid("068a0171-a141-4eb2-854c-88e43ef9ab7f"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission UserDelete = new Permission
        {
            DisplayName = "User delete",
            Name = PermissionNameForUserDelete,
            Id = new Guid("70b5c5c3-2267-4f7c-b0f9-7ecc952e04a6"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission RoleRead = new Permission
        {
            DisplayName = "Role read",
            Name = PermissionNameForRoleRead,
            Id = new Guid("80562f50-8a7d-4bcd-8971-6d856bbcbb7f"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission RoleCreate = new Permission
        {
            DisplayName = "Role create",
            Name = PermissionNameForRoleCreate,
            Id = new Guid("d4d7c0e3-efcf-4dd2-86e7-17d69fda8c75"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission RoleUpdate = new Permission
        {
            DisplayName = "Role update",
            Name = PermissionNameForRoleUpdate,
            Id = new Guid("ea003a99-4755-4c19-b126-c5cffbc65088"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        public static readonly Permission RoleDelete = new Permission
        {
            DisplayName = "Role delete",
            Name = PermissionNameForRoleDelete,
            Id = new Guid("8f76de0b-114a-4df8-a93d-cec927d06a3c"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now
        };

        // add your permissions

        // these strings are using on authorize attributes
        public const string PermissionNameForAdministration = "Permissions_Administration";
        public const string PermissionNameForMemberAccess = "Permissions_Member_Access";
        public const string PermissionNameForUserRead = "Permissions_User_Read";
        public const string PermissionNameForUserCreate = "Permissions_User_Create";
        public const string PermissionNameForUserUpdate = "Permissions_User_Update";
        public const string PermissionNameForUserDelete = "Permissions_User_Delete";
        public const string PermissionNameForRoleRead = "Permissions_Role_Read";
        public const string PermissionNameForRoleCreate = "Permissions_Role_Create";
        public const string PermissionNameForRoleUpdate = "Permissions_Role_Update";
        public const string PermissionNameForRoleDelete = "Permissions_Role_Delete";

        // add your permission names
    }
}
