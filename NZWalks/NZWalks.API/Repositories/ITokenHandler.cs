using Microsoft.IdentityModel.Tokens;
using NZWalks.API.Models.Domain;
using System.Text;

namespace NZWalks.API.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);

    }
}
