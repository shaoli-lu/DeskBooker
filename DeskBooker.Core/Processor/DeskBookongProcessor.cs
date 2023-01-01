﻿using DeskBooker.Core.Domain;
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
            if(request==null)
            {
                throw new ArgumentNullException(nameof(request));
            }
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