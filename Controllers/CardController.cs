using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BinlistAPI.Models;
using BinlistAPI.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BinlistAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //Add authorization attribute
    public class CardController : ControllerBase
    {
      
        private readonly ICardService _cardservice;

        public CardController (ICardService cardservice)
        {
           
            _cardservice = cardservice;
    }

        [HttpGet]
        public async Task<Card> GetCardByissuerIdentificationNumber(int issuerIdentificationNumber)
        {
                 //making my controller code as lean as possible
                return await _cardservice.GetCardByIssuerIdentificationNumberAsync(issuerIdentificationNumber);
       
        }

    }
}
