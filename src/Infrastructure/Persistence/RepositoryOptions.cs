using System.ComponentModel.DataAnnotations;

namespace eCommerce.Infrastructure.Persistence;

public class RepositoryOptions
{
    [Required]
    public string? ConnectionString { get; set; }
}
