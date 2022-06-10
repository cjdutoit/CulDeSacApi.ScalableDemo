// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CulDeSacApi.Brokers.Events;
using CulDeSacApi.Models.Students;

namespace CulDeSacApi.Services.Foundations.StudentEvents
{
    public class StudentEventService : IStudentEventService
    {
        private readonly IEventBroker eventBroker;

        public StudentEventService(IEventBroker eventBroker) =>
            this.eventBroker = eventBroker;

        public void SubscribeToStudentAddEvent(Func<Student, ValueTask<Student>> studentEventHandler) =>
            this.eventBroker.SubscribeToStudentAddEvent(studentEventHandler);
    }
}
