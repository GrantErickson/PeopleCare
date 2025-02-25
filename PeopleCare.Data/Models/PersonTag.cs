﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class PersonTag: TenantedBase
{
    public string PersonTagId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public string TagId { get; set; } = null!;
    public Tag? Tag { get; set; }
}
