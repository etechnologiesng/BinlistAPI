# BinlistAPI
Binlist test

  public class CardServiceTest
    {
        private readonly ICardService _sut;
        private readonly IHttpClientFactory httpClientFactory = Substitute.For<IHttpClientFactory>();
        private readonly ILogger<CardService> logger = Substitute.For<ILogger<CardService>>();
        public CardServiceTest()
        {
            _sut = new CardService(httpClientFactory, logger);
        }
        [Fact]
        public async Task GetCardByIssuerIdentificationNumberAsync_ShouldThrowException_WhenArgumentIsZero()
        {
            var iin = 0;
            await Assert.ThrowsAsync<ArgumentNullException>(()=> _sut.GetCardByIssuerIdentificationNumberAsync(iin));
        }
        //TODO: Write more test
    }
