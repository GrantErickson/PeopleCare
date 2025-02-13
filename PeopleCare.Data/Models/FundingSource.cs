namespace PeopleCare.Data.Models;
public class FundingSource: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string FundingSourceId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public ICollection<Program> Programs { get; set; } = [];
}
