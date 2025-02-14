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

    [ManyToMany("FundingSources", FarNavigationProperty = nameof(ProgramFundingSource.FundingSource))]
    public ICollection<ProgramFundingSource> ProgramFundingSources { get; set; } = null!;

    [ManyToMany("Activities", FarNavigationProperty = nameof(ProgramActivity.Activity))]
    public ICollection<ProgramActivity> ProgramActivities { get; set; } = null!;
}
