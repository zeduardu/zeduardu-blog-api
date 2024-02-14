using Microsoft.EntityFrameworkCore;

namespace ZdPortApi.Domain.Entities;

[Index(nameof(Url), IsUnique = true)]
public class Category : BaseAuditableEntity
{
    public required string Url { get; set; }
    public required string Name { get; set; }
    public string? Summary { get; set; }
}
