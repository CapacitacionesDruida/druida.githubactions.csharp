using druida.githubactions.csharp.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace druida.githubactions.csharp.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
