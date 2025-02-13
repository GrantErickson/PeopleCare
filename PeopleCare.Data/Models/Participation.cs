using PeopleCare.Data.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Participation : TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ParticipationId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }
    public string ActivityId { get; set; } = null!;
    public Activity? Activity { get; set; }

    public string ProgramId { get; set; } = null!;
    public Program? Program { get; set; }

    public string FundingSourceId { get; set; } = null!;
    public FundingSource? FundingSource { get; set; }

    public bool IsRegistered { get; set; }
    public bool IsAttended { get; set; }

    public string? FormId { get; set; }
    public Form? Form { get; set; }

}
