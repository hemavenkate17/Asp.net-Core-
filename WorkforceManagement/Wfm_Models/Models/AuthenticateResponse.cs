
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wfm_Models.Models
{
    public class AuthenticateResponse
    {


        public string Name { get; set; }

        public string Role { get; set; }
        public string Email { get; set; }
        
        public string Token { get; set; }


        public AuthenticateResponse(Users user, string token)
        {
            Name = user.name;
            Role = user.role;
            Email = user.email;
            Token = token;
        }
    }
}
