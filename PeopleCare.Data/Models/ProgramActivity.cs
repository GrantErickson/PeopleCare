﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class ProgramActivity: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProgramActivityId { get; set; } = null!;

    public string ProgramId { get; set; } = null!;
    public Program? Program { get; set; }

    public string ActivityId { get; set; } = null!;
    public Activity? Activity { get; set; }
}
