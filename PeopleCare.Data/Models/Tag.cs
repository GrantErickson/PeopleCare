namespace PeopleCare.Data.Models;
public class Tag: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string TagId { get; set; } = null!;
    public required string Name { get; set; }

    public ICollection<Person> People { get; set; } = [];

}
