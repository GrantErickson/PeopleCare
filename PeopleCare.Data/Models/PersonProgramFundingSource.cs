namespace PeopleCare.Data.Models;
public class PersonProgramFundingSource: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PersonProgramFundingSourceId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string ProgramId { get; set; } = null!;
    public Program? Program { get; set; }

    public string FundingSourceId { get; set; } = null!;
    public FundingSource? FundingSource { get; set; }

    public ProgramState State { get; set; }
    public DateOnly DateEnrolled { get; set; }

    public enum ProgramState
    {
        Enrolled,
        Completed,
        Withdrawn
    }
}
