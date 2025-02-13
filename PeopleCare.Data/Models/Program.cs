using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Program: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProgramId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public ICollection<FundingSource> FundingSources { get; set; } = null!;

    public ICollection<Activity> Activities { get; set; } = null!;
}
