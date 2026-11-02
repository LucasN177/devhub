using Syncro.Core.Interfaces.Infrastructure;
using Syncro.Core.Interfaces.Response;
using Syncro.Core.Interfaces.Services;
using Syncro.Core.Models;
using Syncro.Core.Models.Database;

namespace Syncro.Services;

public class FeatureRequestService(IFeatureRequestRepository featureRequestRepository) : IFeatureRequestService
{
    public const int NameMaxLength = 100;
    public const int MessageMaxLength = 2000;

    public async Task<IResponse> Submit(string projectSlug, string name, string message)
    {
        name = name.Trim();
        message = message.Trim();

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(message))
            return Response.Failure("Name und Text dürfen nicht leer sein", null);
        if (name.Length > NameMaxLength || message.Length > MessageMaxLength)
            return Response.Failure("Name oder Text ist zu lang", null);

        return await featureRequestRepository.Insert(new FeatureRequestDto
        {
            ProjectSlug = projectSlug,
            Name = name,
            Message = message
        });
    }
}
