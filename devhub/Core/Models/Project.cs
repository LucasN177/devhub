using Syncro.Core.Models.Enums;

namespace Syncro.Core.Models;

public class Project
{
    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public ProjectStatus Status { get; set; }
    public int Progress { get; set; }
    public string AccentColor { get; set; } = "#5B5CE2";
    public DateTime StartedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? RepositoryUrl { get; set; }
    public string? LiveUrl { get; set; }
    public List<string> Technologies { get; set; } = [];
    public List<string> Features { get; set; } = [];
    public List<string> NextSteps { get; set; } = [];
    public List<ProjectLink> Links { get; set; } = [];

    public string Initials => string.Concat(Name.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2).Select(w => char.ToUpperInvariant(w[0])));
}

public class ProjectLink
{
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
