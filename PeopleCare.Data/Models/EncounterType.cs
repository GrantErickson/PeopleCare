namespace PeopleCare.Data.Models;
public class EncounterType: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EncounterTypeId { get; set; } = null!;
    public required string Name { get; set; }

}
