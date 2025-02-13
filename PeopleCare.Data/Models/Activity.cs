using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Activity : TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ActivityId { get; set; } = null!;


    public ICollection<Program> Programs { get; set; } = null!;

    public ICollection<Participation> Participants { get; set; } = null!;

    public required string Name { get; set; }
    public string Description { get; set; } = null!;

    public DateTime? Date { get; set; }
    public int DurationInMinutes { get; set; }
}
