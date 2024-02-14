namespace ZdPortApi.Domain.Entities;

public class User : BaseAuditableEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required UserRole Role { get; set; } = UserRole.Reader;
    public required string Password { get; set; }
}
