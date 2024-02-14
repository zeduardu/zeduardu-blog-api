using Microsoft.EntityFrameworkCore;

namespace ZdPortApi.Domain.Entities;

[Index(nameof(Url), IsUnique = true)]
public class Post : BaseAuditableEntity
{
    public required User User { get; set; }
    public required string Url { get; set; }
}
