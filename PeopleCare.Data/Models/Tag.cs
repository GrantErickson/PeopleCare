using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Tag: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string TagId { get; set; } = null!;
    public required string Name { get; set; }

}
