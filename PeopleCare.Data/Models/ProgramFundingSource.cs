namespace PeopleCare.Data.Models;
public class ProgramFundingSource: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProgramFundingSourceId { get; set; } = null!;

    public string ProgramId { get; set; } = null!;
    public Program? Program { get; set; }

    public string FundingSourceId { get; set; } = null!;
    public FundingSource? FundingSource { get; set; }

}
