using Syncro.Core.Interfaces.Response;
using Syncro.Core.Models.Database;

namespace Syncro.Core.Interfaces.Infrastructure;

public interface IFeatureRequestRepository
{
    public Task<IResponse> Insert(FeatureRequestDto featureRequest);
}
