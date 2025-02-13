using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models.Forms;
public class FormValue: TenantedBase
{
    public string FormValueId { get; set; } = null!;

    public string FormId { get; set; } = null!;
    public Form? Form { get; set; }

    public string FormFieldId { get; set; } = null!;
    public FormField? FormField { get; set; }
    
    public string? Value { get; set; } = null!;
}
