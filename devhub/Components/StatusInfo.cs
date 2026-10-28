using MudBlazor;
using Syncro.Core.Models.Enums;

namespace devhub.Components;

public static class StatusInfo
{
    public static string Label(this ProjectStatus status) => status switch
    {
        ProjectStatus.Idea => "Idee",
        ProjectStatus.Planning => "In Planung",
        ProjectStatus.Active => "Aktiv",
        ProjectStatus.Paused => "Pausiert",
        ProjectStatus.Completed => "Abgeschlossen",
        _ => status.ToString()
    };

    public static Color Color(this ProjectStatus status) => status switch
    {
        ProjectStatus.Idea => MudBlazor.Color.Tertiary,
        ProjectStatus.Planning => MudBlazor.Color.Info,
        ProjectStatus.Active => MudBlazor.Color.Success,
        ProjectStatus.Paused => MudBlazor.Color.Warning,
        ProjectStatus.Completed => MudBlazor.Color.Primary,
        _ => MudBlazor.Color.Default
    };

    public static string Icon(this ProjectStatus status) => status switch
    {
        ProjectStatus.Idea => Icons.Material.Rounded.Lightbulb,
        ProjectStatus.Planning => Icons.Material.Rounded.EditCalendar,
        ProjectStatus.Active => Icons.Material.Rounded.RocketLaunch,
        ProjectStatus.Paused => Icons.Material.Rounded.PauseCircle,
        ProjectStatus.Completed => Icons.Material.Rounded.CheckCircle,
        _ => Icons.Material.Rounded.Circle
    };
}
