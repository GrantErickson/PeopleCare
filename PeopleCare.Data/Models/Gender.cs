using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Gender: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string GenderId { get; set; } = null!;
    public required string Name { get; set; }
}

