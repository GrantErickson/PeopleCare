using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class RelationshipType: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string RelationshipTypeId { get; set; } = null!;
    public string Name { get; set; } = null!;

    // This has to be nullable because the opposite relationship may not be created yet.
    [ForeignKey("OppositeRelationshipTypeId")]
    public string? OppositeRelationshipTypeId { get; set; }
    public RelationshipType? OppositeRelationshipType { get; set; }

    public required string EntityName { get; set; }
    public required string RelatedEntityName { get; set; }
}
