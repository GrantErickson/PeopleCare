namespace PeopleCare.Data.Models;
public class Gender: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string GenderId { get; set; } = null!;
    public required string Name { get; set; }
}

