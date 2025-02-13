using System.ComponentModel;

namespace PeopleCare.Data.Models;
public class PersonType : TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PersonTypeId { get; set; } = null!;

    public required string Name { get; set; }

    [DisplayName("Has Care Needs")]
    public bool HasCareNeeds { get; set; }
    [DisplayName("Has Care Assets")]
    public bool HasCareAssets { get; set; }
    [DisplayName("Is an Organization")]
    public bool IsOrganization { get; set; }

    public ICollection<Person> People { get; set; } = [];
}
