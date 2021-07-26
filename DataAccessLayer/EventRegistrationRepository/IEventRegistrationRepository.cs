﻿using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.DataAccessLayer.EventRegistrationRepository
{
    public interface IEventRegistrationRepository
    {
        int AddRegistration(EventRegistration er);

        Task<List<EventRegistration>> fetchEventRegistrationsByUserId(int userId);

        EventRegistration findEventRegistrationByUserIdAndEventId(int userId, int eventId);

        Task<List<EventRegistration>> fetchEventRegistrationsByEventId(int eventId);

        EventRegistration findEventRegistrationById(int eventRegistrationId);

        int UpdateEventRegistration(EventRegistration er);

    }
}
