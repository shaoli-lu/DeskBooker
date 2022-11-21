using System;

namespace DeskBooker.Core.Processor
{
    public class DeskBookongProcessor
    {
        public DeskBookongProcessor()
        {
        }

        public DeskBookingResult BookDesk(DeskBookingRequest request)
        {
            return new DeskBookingResult
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Date = request.Date
            };
        }
    }
}