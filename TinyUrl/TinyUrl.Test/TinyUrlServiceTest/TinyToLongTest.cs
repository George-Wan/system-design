using Moq;
using NUnit.Framework;
using TinyUrl.Data;
using TinyUrl.Service;

namespace TinyUrl.Test.TinyUrlServiceTest
{
    public class TinyToLongTest
    {
        private int id = 1;
        private string longUrl = "https://stackoverflow.blog/this_is_a_long_url_for_base62_number_000001";
        private string tinyUrl = "000001";
        private Mock<ITinyUrlDataAccess> mockObject;

        [SetUp]
        public void Setup()
        {
            mockObject = new Mock<ITinyUrlDataAccess>();
            mockObject.Setup(m => m.GetLongUrl(id)).Returns(longUrl);
        }

        [Test]
        public void TinyToLong_Base62_Num_000001()
        {
            
            TinyUrlService tinyUrlService = new TinyUrlService(mockObject.Object);

            var url  = tinyUrlService.TinyToLong(tinyUrl);

            Assert.AreEqual(longUrl,url);

        }

        [Test]
        public void TinyToLong_GetLongUrl_Called_Once()
        {
            TinyUrlService tinyUrlService = new TinyUrlService(mockObject.Object);

            var url = tinyUrlService.TinyToLong(tinyUrl);

            mockObject.Verify(m => m.GetLongUrl(It.IsAny<int>()), Times.Once);

        }
    }
}