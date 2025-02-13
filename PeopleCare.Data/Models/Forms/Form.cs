using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models.Forms;
public class Form: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string FormId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }


    public string FormTypeId { get; set; } = null!;
    public FormType? FormType { get; set; }

    public DateTime Date { get; set; }

    public ICollection<FormFieldValue> FormValues { get; set; } = null!;

}
