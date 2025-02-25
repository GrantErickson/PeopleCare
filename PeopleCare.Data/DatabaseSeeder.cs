﻿namespace PeopleCare.Data;

public class DatabaseSeeder(AppDbContext db)
{
    public void Seed()
    {
        if (!db.Tenants.Any())
        {
            var tenant = new Tenant { Name = "Demo Tenant" };
            db.Add(tenant);
            db.SaveChanges();

            SeedNewTenant(tenant);
        }
    }

    public void SeedNewTenant(Tenant tenant, string? userId = null)
    {
        var tenantId = tenant.TenantId;
        db.TenantId = tenantId;

        SeedRoles();

        if (userId is not null)
        {
            // Give the first user in the tenant all roles so there is an initial admin.
            db.AddRange(db.Roles.Select(r => new UserRole { Role = r, UserId = userId }));
            db.Add(new TenantMembership { UserId = userId });
        }

        db.SaveChanges();
    }

    private void SeedRoles()
    {
        if (!db.Roles.Any())
        {
            db.Roles.Add(new()
            {
                Permissions = Enum.GetValues<Permission>().ToList(),
                Name = "Admin",
                NormalizedName = "ADMIN",
            });

            // NOTE: In this application's permissions-based authorization system,
            // additional roles can freely be created by administrators.
            // You don't have to seed every possible role.

            db.SaveChanges();
        }
    }

    /// <summary>
    /// Grant administrative permissions to the very first user in the application.
    /// </summary>
    public void InitializeFirstUser(User user)
    {
        if (db.Users.Any()) return;

        // If this user is the first user, make them the global admin
        user.IsGlobalAdmin = true;

        // Ensure that the very first user belongs to a tenant so they can create more tenants.
        var tenant = db.Tenants.FirstOrDefault(t => t.Name == "Demo Tenant");
        if (tenant is not null) 
        {
            db.TenantId = tenant.TenantId;
            db.TenantMemberships.Add(new() { TenantId = tenant.TenantId, User = user });
            user.UserRoles = db.Roles.Select(r => new UserRole { Role = r, User = user }).ToList();
        }
    }
}
