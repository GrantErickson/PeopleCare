using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Region : TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string RegionId { get; set; } = null!;

    public required string Name { get; set; }
    public required string Code { get; set; } // Used for times when the whole region name is too long to display

    public string? ParentRegionId { get; set; }
    public Region? ParentRegion { get; set; }

    public IList<Region> Children { get; set; } = new List<Region>();

    public ICollection<Person> PeopleWithAccess { get; set; } = null!;

    /// <summary>
    /// Returns the index of the level of this region in the hierarchy with 0 being the top
    /// </summary>
    [NotMapped]
    public int Level
    {
        get
        {
            if (ParentRegion == null) return 0;
            else return ParentRegion.Level + 1;
        }
    }

}
