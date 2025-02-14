using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class FundingSource: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string FundingSourceId { get; set; } = null!;
    public string Name { get; set; } = null!;
    [ManyToMany("Programs", FarNavigationProperty = nameof(ProgramActivity.Program))]
    public ICollection<ProgramFundingSource> ProgramFundingSources { get; set; } = null!;
}
