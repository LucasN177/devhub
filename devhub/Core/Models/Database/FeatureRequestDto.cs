using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Syncro.Core.Models.Database;

[Table("feature_requests")]
public class FeatureRequestDto : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("project_slug")]
    public string ProjectSlug { get; set; } = string.Empty;

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("message")]
    public string Message { get; set; } = string.Empty;
}
