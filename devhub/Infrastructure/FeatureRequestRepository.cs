using Supabase.Postgrest;
using Syncro.Core.Interfaces.Infrastructure;
using Syncro.Core.Interfaces.Response;
using Syncro.Core.Models;
using Syncro.Core.Models.Database;

namespace Syncro.Infrastructure;

// The Supabase client is resolved on first use, so a missing Supabase configuration
// only fails the submission instead of breaking every project page
public class FeatureRequestRepository(IServiceProvider serviceProvider) : IFeatureRequestRepository
{
    public async Task<IResponse> Insert(FeatureRequestDto featureRequest)
    {
        try
        {
            var client = serviceProvider.GetRequiredService<Supabase.Client>();
            // Anonymous users may insert but not select, so no row can be returned
            await client.From<FeatureRequestDto>()
                .Insert(featureRequest, new QueryOptions { Returning = QueryOptions.ReturnType.Minimal });
            return Response.Success();
        }
        catch (Exception ex)
        {
            return Response.Failure(ex.Message, ex);
        }
    }
}
