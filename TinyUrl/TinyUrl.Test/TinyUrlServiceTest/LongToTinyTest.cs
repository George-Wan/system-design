using Moq;
using NUnit.Framework;
using TinyUrl.Data;
using TinyUrl.Service;

namespace TinyUrl.Test.TinyUrlServiceTest
{
    public class LongToTinyTest
    {
        private int id = 1;
        private string longUrl = "https://stackoverflow.blog/this_is_a_long_url_for_base62_number_000001";
        private string tinyUrl = "000001";
        private Mock<ITinyUrlDataAccess> mockObject;

        [SetUp]
        public void Setup()
        {
            mockObject = new Mock<ITinyUrlDataAccess>();
            mockObject.Setup(m => m.CreateTinyUrl(longUrl)).Returns(id);
        }

        [Test]
        public void LongToTiny_First_LongUrl()
        {
            
            TinyUrlService tinyUrlService = new TinyUrlService(mockObject.Object);

            var url  = tinyUrlService.LongToTiny(longUrl);

            Assert.AreEqual(tinyUrl, url);

        }

        [Test]
        public void LongToTiny_CreateTinyUrl_Called_Once()
        {
            TinyUrlService tinyUrlService = new TinyUrlService(mockObject.Object);

            var url = tinyUrlService.LongToTiny(longUrl);

            mockObject.Verify(m => m.CreateTinyUrl(It.IsAny<string>()), Times.Once);

        }
    }
}