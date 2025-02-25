﻿using System.ComponentModel;

namespace PeopleCare.Data.Models;

[Read(AllowAuthenticated)]
[Edit(Roles = nameof(Permission.Admin))]
[Create(DenyAll)]
[Delete(DenyAll)]
[Display(Name = "Organization")]
public class Tenant
{
    [MaxLength(36)]
    public string TenantId { get; set; } = Guid.NewGuid().ToString();

    public required string Name { get; set; }


    [DefaultDataSource]
    public class DefaultSource(CrudContext<AppDbContext> context) : AppDataSource<Tenant>(context)
    {
        public override IQueryable<Tenant> GetQuery(IDataSourceParameters parameters)
        {
            // Only allow the current tenant to be read and modified.
            return base.GetQuery(parameters)
                .Where(t => t.TenantId == User.GetTenantId());
        }
    }

    public class GlobalAdminSource(CrudContext<AppDbContext> context) : AppDataSource<Tenant>(context)
    {
        public override IQueryable<Tenant> GetQuery(IDataSourceParameters parameters)
        {
            if (!User.IsInRole(AppClaimValues.GlobalAdminRole))
            {
                return Enumerable.Empty<Tenant>().AsQueryable();
            }

            return base.GetQuery(parameters);
        }
    }

    [Coalesce, Execute(AppClaimValues.GlobalAdminRole)]
    public static async Task<ItemResult> Create(
        AppDbContext db,
        [Inject] InvitationService invitationService,
        [Display(Name = "Org Name")] string name,
        [DataType(DataType.EmailAddress)] string adminEmail
    )
    {
        Tenant tenant = new() { Name = name };
        db.Tenants.Add(tenant);
        await db.SaveChangesAsync();

        db.ForceSetTenant(tenant.TenantId);
        new DatabaseSeeder(db).SeedNewTenant(tenant);

        return await invitationService.CreateAndSendInvitation(adminEmail, db.Roles.ToArray());
    }
}
