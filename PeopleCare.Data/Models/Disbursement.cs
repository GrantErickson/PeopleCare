namespace PeopleCare.Data.Models;
public class Disbursement : TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string DisbursementId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string DonationId { get; set; } = null!;
    public Donation? Donation { get; set; }

    public string RegionId { get; set; } = null!;
    public Region? Region { get; set; }

    public string? Description {get; set; } // This will likely be set by the Donation Description field.
    public DateOnly Date { get; set; }
    public decimal Value { get; set; }
    public int Quantity { get; set; }
}
