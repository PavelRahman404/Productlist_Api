using Microsoft.AspNetCore.Identity;

namespace Assignment_Productlist_Api.Repository
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
