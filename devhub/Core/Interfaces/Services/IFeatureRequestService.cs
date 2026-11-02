using Syncro.Core.Interfaces.Response;

namespace Syncro.Core.Interfaces.Services;

public interface IFeatureRequestService
{
    public Task<IResponse> Submit(string projectSlug, string name, string message);
}
