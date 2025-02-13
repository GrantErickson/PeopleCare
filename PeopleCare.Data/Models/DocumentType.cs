using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class DocumentType: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string DocumentTypeId { get; set; } = null!;
    public ICollection<Document> Documents { get; set; } = null!;
    public required string Name { get; set; }
}

