using Moq;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace StrictVsLoose.Test.Loose
{
    public class MessageProcessorLooseTest
    {
        [Fact]
        public void ShouldReturnFalseOnError()
        {
            // Arrange
            var incomingMessages = new List<string>
            {
                "Message 1",
                "Message 2"
            };

            var messageHandlerMock = new Mock<IMessageHandler>();

            messageHandlerMock
                .Setup(x => x.HandleMessage(It.IsAny<string>()))
                .Returns(false);

            var itemUnderTest = new MessageProcessor(messageHandlerMock.Object);

            // Act
            var result = itemUnderTest.ProcessMessages(incomingMessages);

            // Assert
            result.ShouldBeFalse();
        }

        [Fact]
        public void ShouldReturnTrueOnSuccess()
        {
            // Arrange
            var incomingMessages = new List<string>
            {
                "Message 1",
                "Message 2"
            };

            var messageHandlerMock = new Mock<IMessageHandler>();

            messageHandlerMock
                .Setup(x => x.HandleMessage(It.IsAny<string>()))
                .Returns(true);

            var itemUnderTest = new MessageProcessor(messageHandlerMock.Object);

            // Act
            var result = itemUnderTest.ProcessMessages(incomingMessages);

            // Assert
            result.ShouldBeTrue();
        }
    }
}