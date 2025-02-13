using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models.Forms;
public class FormType: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string FormTypeId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public ICollection<Form> Forms { get; set; } = [];

    public ICollection<FormTypeField> Fields { get; set; } = [];
}
