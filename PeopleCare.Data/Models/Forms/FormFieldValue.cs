using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models.Forms;
public class FormFieldValue: TenantedBase
{
    public string FormFieldValueId { get; set; } = null!;

    public string FormId { get; set; } = null!;
    public Form? Form { get; set; }

    public string FormTypeFieldId { get; set; } = null!;
    public FormTypeField? FormTypeField { get; set; }
    
    public string? Value { get; set; } = null!;
}
