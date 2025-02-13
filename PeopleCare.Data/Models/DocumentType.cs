namespace PeopleCare.Data.Models;
public class DocumentType: TenantedBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string DocumentTypeId { get; set; } = null!;
    public ICollection<Document> Documents { get; set; } = [];
    public required string Name { get; set; }
}

