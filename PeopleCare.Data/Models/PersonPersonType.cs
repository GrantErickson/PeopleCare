namespace PeopleCare.Data.Models;
public class PersonPersonType: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PersonPersonTypeId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string PersonTypeId { get; set; } = null!;
    public PersonType? PersonType { get; set; }
}
