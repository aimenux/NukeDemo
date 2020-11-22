using FluentAssertions;
using Lib;
using NUnit.Framework;

namespace Tests
{
    public class DummyServiceTests
    {
        [Test]
        public void GetStartingMessage_Should_Returns_Valid_Message()
        {
            // arrange
            var service = new DummyService();

            // act
            var message = service.GetStartingMessage();

            // assert
            message.Should().Be("App is starting.");
        }

        [Test]
        public void GetStoppingMessage_Should_Returns_Valid_Message()
        {
            // arrange
            var service = new DummyService();

            // act
            var message = service.GetStoppingMessage();

            // assert
            message.Should().Be("App is stopping.");
        }
    }
}