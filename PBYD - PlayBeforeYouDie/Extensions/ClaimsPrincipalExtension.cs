using System.Security.Claims;

namespace PBYD___PlayBeforeYouDie.Extensions;

public static class ClaimsPrincipalExtension
{
    public static string Id(this ClaimsPrincipal user)
    {
        return user.FindFirstValue(ClaimTypes.NameIdentifier);

    }
}