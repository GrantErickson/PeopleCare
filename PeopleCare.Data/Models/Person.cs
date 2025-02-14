using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PeopleCare.Data.Models.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Person: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PersonId { get; set; } = null!;

    public required string RegionId { get; set; }
    public Region? Region { get; set; }

    public string? UserId { get; set; }
    public User? User { get; set; }


    [ManyToMany("AvailableRegions", FarNavigationProperty = nameof(PersonRegionAccess.Region))]
    public ICollection<PersonRegionAccess> PeopleRegionAccesses { get; set; } = null!;

    [ManyToMany("PersonTypes", FarNavigationProperty = nameof(PersonPersonType.PersonType))]
    public ICollection<PersonPersonType> PersonPersonTypes { get; set; } = null!;

    [ForeignKey(nameof(Encounter.PersonId))]
    public ICollection<Encounter> Encounters { get; set; } = null!;
    [InverseProperty(nameof(Encounter.Person))]
    public ICollection<Donation> Donations { get; set; } = null!;
    [InverseProperty(nameof(Disbursement.Person))]
    public ICollection<Disbursement> Disbursements { get; set; } = null!;
    [InverseProperty(nameof(Relationship.Person))]
    public ICollection<Relationship> Relationships { get; set; } = null!;
    public ICollection<PersonTag> PersonTags { get; set; } = null!;
    public ICollection<Form> Forms { get; set; } = null!;
    public ICollection<Document> Documents { get; set; } = null!;

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
