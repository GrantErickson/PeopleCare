using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models.Forms;
public class FormTypeField : TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string FormTypeFieldId { get; set; } = null!;

    public string FormTypeId { get; set; } = null!;
    public FormType? FormType { get; set; }

    public required string Name { get; set; }
    public string? Description { get; set; } = null!;

    public required FormFieldType Type { get; set; }

    public string? ValidValues { get; set; }


    public enum FormFieldType
    {
        Number = 1,
        ShortText = 2,
        LongText = 3,
        Selection = 4,
    }
}
