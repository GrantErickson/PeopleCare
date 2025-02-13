using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCare.Data.Models;
public class Document: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string DocumentId { get; set; } = null!;

    public string PersonId { get; set; } = null!;
    public Person? Person { get; set; }

    public required string DocumentName { get; set; }
    public required string Url { get; set; }

    public string DocumentTypeId { get; set; } = null!;
    public DocumentType? DocumentType { get; set; }
}
