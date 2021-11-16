using BinlistAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinlistAPI.Services.Contracts
{
   public interface IIdentityService
    {
        Task<AuthResult> RegisterAsync(string email, string password);

        Task<AuthResult> LoginWithFacebookAsync(string accessToken);
    }
}
