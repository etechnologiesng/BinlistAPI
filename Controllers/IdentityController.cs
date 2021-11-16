using BinlistAPI.Models;
using BinlistAPI.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinlistAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService _identityService;
        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpGet]
        public async Task<IActionResult> FacebookAuth(string accessToken)
        {
            var authResponse = await _identityService.LoginWithFacebookAsync(accessToken);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthResult
                {
                    Errors = authResponse.Errors,
                    Success = false
                    
                });
            }

            return Ok(new AuthResult
            {
                Token = authResponse.Token,
                Success = true
                
            });
        }
    }
}
