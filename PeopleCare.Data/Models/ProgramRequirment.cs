namespace PeopleCare.Data.Models;
public class ProgramRequirment
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProgramRequirmentId { get; set; } = null!;

    [Required]
    public string ProgramId { get; set; } = null!;
    public Program? Program { get; set; }
}
