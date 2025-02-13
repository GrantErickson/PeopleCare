namespace PeopleCare.Data.Models;
public class Donation: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string DonationId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string RegionId { get; set;} = null!;
    public Region? Region { get; set; }

    public string? Description { get; set; }
    public bool IsInKind { get; set; }
    public decimal Value { get; set; }
    public int Quantity { get; set; }
    public DateOnly Date { get; set; }

    public ICollection<Disbursement> Disbursements { get; set; } = [];
}
