namespace PeopleCare.Data.Models;
public class PersonRegionAccess: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PersonRegionAccessId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string RegionId { get; set; } = null!;
    public Region? Region { get; set; }
}
