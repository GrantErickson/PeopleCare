﻿namespace PeopleCare.Data;

public static class AppClaimTypes
{
    public const string Role = "role";
    public const string Permission = "perm";
    public const string UserId = "sub";
    public const string UserName = "username";
    public const string Email = "email";
    public const string FullName = "name";
    public const string TenantId = "tid";
}

public static class AppClaimValues
{
    public const string GlobalAdminRole = "GlobalAdmin";
    public const string NullTenantId = "00000000-0000-0000-0000-000000000000";
}
