using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
[Create(SecurityPermissionLevels.DenyAll)]
public class Relationship: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string RelationshipId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string RelatedPersonId { get; set; } = null!;
    public Person? RelatedPerson { get; set; }

    public string RelationshipTypeId { get; set; } = null!;
    public RelationshipType? RelationshipType { get; set; }

    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public Boolean IsActive { get; set; }

    public string? Note { get; set; }

    public string? OppositeRelationshipId { get; set; }
    [ForeignKey(nameof(OppositeRelationshipId))]
    public Relationship? OppositeRelationship { get; set; }

    [Coalesce]
    public static Relationship Create(Person person, Person relatedPerson, string relationshipTypeId, AppDbContext db)
    {
        // Create the Relationship
        Relationship rNew = new();
        rNew.Person = person;
        rNew.RelatedPerson = relatedPerson;
        rNew.IsActive = true;
        rNew.RelationshipType = db.RelationshipTypes.First(f => f.RelationshipTypeId == relationshipTypeId);
        rNew.StartDate = DateOnly.FromDateTime(DateTime.UtcNow);
        db.Relationships.Add(rNew);
        db.SaveChanges();
        // Create the opposite as well.
        if (rNew.RelationshipType.OppositeRelationshipTypeId is not null && rNew.RelationshipType.OppositeRelationshipTypeId is not null)
        {
            Relationship rOther = rNew.CreateOpposite();
            rOther.RelationshipType = db.RelationshipTypes.First(f => f.RelationshipTypeId == rNew.RelationshipType.OppositeRelationshipTypeId);
            db.Relationships.Add(rOther);
            db.SaveChanges();
        }
        return rNew;
    }



    /// <summary>
    /// Creates an opposite relationship based on this relationship
    /// </summary>
    /// <returns></returns>
    private Relationship CreateOpposite()
    {
        Relationship ro = new();
        ro.Person = this.RelatedPerson;
        ro.RelatedPerson = this.Person;
        ro.StartDate = this.StartDate;
        ro.IsActive = this.IsActive;
        ro.OppositeRelationship = this;
        UpdateOpposite(ro); // Is this needed?
        this.OppositeRelationship = ro;
        return ro;
    }

    /// <summary>
    /// Updates the opposite relationship based on this relationship
    /// </summary>
    /// <returns></returns>
    public void UpdateOpposite(Relationship opposite)
    {
        opposite.Person = this.RelatedPerson;
        opposite.IsActive = this.IsActive;
        opposite.Note = this.Note;
        opposite.EndDate = this.EndDate;
        opposite.RelationshipTypeId = this.RelationshipType!.OppositeRelationshipTypeId!;
        opposite.StartDate = this.StartDate;
    }
}
