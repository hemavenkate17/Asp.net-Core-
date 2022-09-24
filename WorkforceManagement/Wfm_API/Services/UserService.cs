using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Wfm_API.Helpers;
using Wfm_DBContext.Models;
using Wfm_Models.Models;

namespace Wfm_API.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<Users> GetAll();
        Users GetById(int id);

    }

    public class  UserService : IUserService
    {


        private readonly EFContext _context;


        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings,EFContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;

        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
             
             var user = GetAll().SingleOrDefault(x => x.username == model.Username && x.password == model.Password);

       
            if (user == null) return null;

            
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public Users GetById(int id)
        {
            return _context.users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Users> GetAll()
        {
            
             var query = _context.users.ToList();
             return query;
        }

     
        private string generateJwtToken(Users user)
        {
           
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("create jwt token with security key");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

      
    }
   
}
