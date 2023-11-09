using druida.githubactions.csharp.Infrastructure.Identity;

namespace druida.githubactions.csharp.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
