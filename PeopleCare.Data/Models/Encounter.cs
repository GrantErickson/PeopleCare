namespace PeopleCare.Data.Models;
public class Encounter: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EncounterId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string ContactedById { get; set; } = null!;
    public Person? ContactedBy { get; set; }

    public string RegionId { get; set; } = null!;
    public Region? Region { get; set; }

    public string EncounterTypeId { get; set; } = null!;
    public EncounterType? EncounterType { get; set; }

    public string? Notes { get; set; }
    public string? Location { get; set; }
    public DateTime? Date { get; set; }
    public int? DurationInMinutes { get; set; }
}
