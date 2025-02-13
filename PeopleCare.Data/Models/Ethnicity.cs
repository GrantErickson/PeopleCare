namespace PeopleCare.Data.Models;
public class Ethnicity: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EthnicityId { get; set; } = null!;
    public required string Name { get; set; }
}
