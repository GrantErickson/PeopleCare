namespace PeopleCare.Data.Models;
public class Activity : TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ActivityId { get; set; } = null!;


    [ManyToMany($"{nameof(Program)}s", FarNavigationProperty = nameof(ProgramActivity.Program))]
    public ICollection<ProgramActivity> ProgramActivities { get; set; } = [];

    public ICollection<Participation> Participants { get; set; } = [];

    public required string Name { get; set; }
    public string Description { get; set; } = null!;

    public DateTime? Date { get; set; }
    public int DurationInMinutes { get; set; }
}
