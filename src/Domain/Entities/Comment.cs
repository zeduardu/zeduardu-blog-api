namespace ZdPortApi.Domain.Entities;

public class Comment : BaseAuditableEntity
{
    public required Post Post { get; set; }
    public required User User { get; set; }
    public DateTime Date { get; set; }
    public required string Text { get; set; }
}
