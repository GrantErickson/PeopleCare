using PeopleCare.Data;
using PeopleCare.Data.Auth;
using PeopleCare.Data.Models;
using IntelliTect.Coalesce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace PeopleCare.Web.Pages;

[Authorize]
public class InvitationModel(
    InvitationService invitationService,
    SignInManager<User> signInManager,
    AppDbContext db
) : PageModel
{
    [BindProperty(SupportsGet = true), Required]
    public string Code { get; set; }

    internal UserInvitation Invitation { get; private set; }

    internal Tenant Tenant { get; private set; }

    public void OnGet()
    {
        DecodeInvitation();
    }

    public async Task<IActionResult> OnPost()
    {
        DecodeInvitation();
        if (!ModelState.IsValid) return Page();

        db.ForceSetTenant(Invitation.TenantId);

        var user = await db.Users.FindAsync(User.GetUserId());
        var result = await invitationService.AcceptInvitation(Invitation, user!);
        if (!result.WasSuccessful)
        {
            ModelState.AddModelError(nameof(Code), result.Message);
            return Page();
        }

        // Sign the user into the newly joined tenant (uses `db.TenantId`).
        await signInManager.RefreshSignInAsync(user);

        return Redirect("/");
    }

    private void DecodeInvitation()
    {
        if (string.IsNullOrWhiteSpace(Code)) return;

        var decodeResult = invitationService.DecodeInvitation(Code);
        if (!decodeResult.WasSuccessful)
        {
            ModelState.AddModelError(nameof(Code), decodeResult.Message);
            return;
        }
        Invitation = decodeResult.Object;

        var tenant = db.Tenants.Find(Invitation.TenantId);
        if (tenant is null)
        {
            ModelState.AddModelError(nameof(Code), "The invitation link is not valid.");
            return;
        }
        Tenant = tenant;
    }
}
