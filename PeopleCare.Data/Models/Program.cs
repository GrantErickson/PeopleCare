namespace PeopleCare.Data.Models;
public class Program: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProgramId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    [Required]
    public string FundingSourceId { get; set; } = null!;
    public FundingSource? FundingSource { get; set; }

    public ICollection<Activity> Activities { get; set; } = [];
}
