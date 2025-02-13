using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Ethnicity: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EthnicityId { get; set; } = null!;
    public required string Name { get; set; }
}
