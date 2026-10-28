using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Syncro.Core.Interfaces.Response;
using Syncro.Core.Interfaces.Services;
using Syncro.Core.Models;

namespace Syncro.Services;

public class ProjectService(HttpClient httpClient) : IProjectService
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
    {
        Converters = { new JsonStringEnumConverter() }
    };

    private IReadOnlyList<Project>? _projects;

    public async Task<IResponse<IReadOnlyList<Project>>> GetProjects()
    {
        if (_projects is not null)
            return Response<IReadOnlyList<Project>>.Success(_projects);

        try
        {
            var projects = await httpClient.GetFromJsonAsync<List<Project>>("data/projects.json", JsonOptions) ?? [];
            _projects = projects.OrderByDescending(p => p.UpdatedAt).ToList();
            return Response<IReadOnlyList<Project>>.Success(_projects);
        }
        catch (Exception ex)
        {
            return Response<IReadOnlyList<Project>>.Failure(ex);
        }
    }

    public async Task<IResponse<Project>> GetProject(string slug)
    {
        var result = await GetProjects();
        if (!result.IsSuccess || result.Data is null)
            return Response<Project>.Failure(result.ErrorMessage ?? "Projekte konnten nicht geladen werden");

        var project = result.Data.FirstOrDefault(p => string.Equals(p.Slug, slug, StringComparison.OrdinalIgnoreCase));
        return project is not null ? Response<Project>.Success(project) : Response<Project>.Failure("Projekt nicht gefunden");
    }
}
