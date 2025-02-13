namespace PeopleCare.Data.Models;
public class Program: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProgramId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    [ManyToMany($"{nameof(FundingSource)}s", FarNavigationProperty = nameof(ProgramFundingSource.FundingSource))]
    public ICollection<ProgramFundingSource> ProgramFundingSources { get; set; } = [];

    public ICollection<Activity> Activities { get; set; } = [];
}
