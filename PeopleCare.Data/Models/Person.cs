using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PeopleCare.Data.Models.Forms;

namespace PeopleCare.Data.Models;
public class Person: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PersonId { get; set; } = null!;

    public required string RegionId { get; set; }
    public Region? Region { get; set; }

    public string? UserId { get; set; }
    public User? User { get; set; }


    public ICollection<Region> RegionsAvailable { get; set; } = [];

    [ManyToMany($"{nameof(PersonType)}s", FarNavigationProperty = nameof(PersonPersonType.PersonType))]
    public ICollection<PersonPersonType> PersonTypes { get; set; } = [];

    [InverseProperty(nameof(Encounter.Person))]
    public ICollection<Encounter> Encounters { get; set; } = [];
    public ICollection<Donation> Donations { get; set; } = [];
    [InverseProperty(nameof(Disbursement.Person))]
    public ICollection<Disbursement> Disbursements { get; set; } = [];
    [InverseProperty(nameof(Relationship.Person))]
    public ICollection<Relationship> Relationships { get; set; } = [];
    [ManyToMany($"{nameof(Tag)}s", FarNavigationProperty = nameof(PersonTag.Tag))]
    public ICollection<PersonTag> Tags { get; set; } = [];
    public ICollection<Form> Forms { get; set; } = [];
    public ICollection<Document> Documents { get; set; } = [];

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    // Do we need multiple addresses?
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? Country { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public Ethnicity? Ethnicity { get; set; }
    public int? EthnicityId { get; set; }

    public string? CountryOfOrigin { get; set; }
    public string? CityOfOrigin { get; set; }

    public string? GenderId { get; set; }
    public Gender? Gender { get; set; }

    public string? PointPersonId { get; set; }
    [ForeignKey(nameof(PointPersonId))]
    public Person? PointPerson { get; set; }

    public string? Notes { get; set; }

}
