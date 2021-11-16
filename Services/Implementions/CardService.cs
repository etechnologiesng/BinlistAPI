using BinlistAPI.Models;
using BinlistAPI.Services.Contracts;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BinlistAPI.Services.Implementions
{
    public class CardService : ICardService
    {
        private const string BinlistUrl = "https://lookup.binlist.net/{0}";
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<CardService> _logger;
        public CardService(IHttpClientFactory httpClientFactory, ILogger<CardService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }
        public async Task<Card> GetCardByIssuerIdentificationNumberAsync(int issuerIdentificationNumber)
        {
           
            try
            {
                if (issuerIdentificationNumber == 0)
                {
                    throw new ArgumentNullException();
                }
                var formattedUrl = string.Format(BinlistUrl, issuerIdentificationNumber);
                var result = await _httpClientFactory.CreateClient().GetAsync(formattedUrl);
                result.EnsureSuccessStatusCode();
                var responseAsString = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Card>(responseAsString);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong getting card information for {issuerIdentificationNumber}");
                throw;
            }
            return null;
        }
    }
}
