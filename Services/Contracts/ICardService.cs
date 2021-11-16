using BinlistAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinlistAPI.Services.Contracts
{
    public interface ICardService
    {
        Task<Card> GetCardByIssuerIdentificationNumberAsync(int issuerIdentificationNumber);
    }
}
