using AmdarisInternship.Domain.Entities.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Services.Interfaces
{
    public interface IAuthenticateService
    {
        Task<JwtSecurityToken> Login(LoginModel model);

        Task<Response> Register(RegisterModel model);
    }
}