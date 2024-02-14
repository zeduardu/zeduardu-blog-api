namespace ZdPortApi.Domain.Entities;

public class PostCategory : BaseAuditableEntity
{
    public required Post Post { get; set; }
    public required Category Category { get; set; }
}
