using System;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestValue()
        {
            // Arrange
            var request = new DeskBookingRequest
            {
                FirstName = "Shaoli",
                LastName = "Lu",
                Email = "shaoli_lu@yahoo.com",
                Date = new DateTime(2022, 11, 14)
            };

            var processor = new DeskBookongProcessor();

            // Act
            DeskBookingResult result = processor.BookDesk(request);

            // AssertS
            Assert.NotNull(result);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

        }
    }
}
