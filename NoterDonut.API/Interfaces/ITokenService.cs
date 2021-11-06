using System.Threading.Tasks;
using NoterDonut.DATA.Entities;

namespace NoterDonut.API.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}