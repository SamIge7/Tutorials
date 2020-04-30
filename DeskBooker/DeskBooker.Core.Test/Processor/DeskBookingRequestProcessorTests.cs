using System;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnDeskBookingResultsWithRequestValues()
        {
            var request = new DeskBookingRequest
            {
                FirstName = "Sam",
                LastName = "Ige",
                Email = "samige7@yahoo.co.uk",
                Date = new DateTime(2020, 1, 28)
            };

            var processor = new DeskBookingRequestProcessor();

            DeskBookingResult result = processor.BookDesk(request);
        }
    }
}
