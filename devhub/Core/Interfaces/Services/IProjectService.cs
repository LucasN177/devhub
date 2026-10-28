using Syncro.Core.Interfaces.Response;
using Syncro.Core.Models;

namespace Syncro.Core.Interfaces.Services;

public interface IProjectService
{
    public Task<IResponse<IReadOnlyList<Project>>> GetProjects();

    public Task<IResponse<Project>> GetProject(string slug);
}
