// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CulDeSacApi.Models.Students;

namespace CulDeSacApi.Brokers.Events
{
    public partial class EventBroker : IEventBroker
    {
        private static Func<Student, ValueTask<Student>> StudentAddEventHandler;

        public void SubscribeToStudentAddEvent(Func<Student, ValueTask<Student>> studentAddEventHandler) =>
            StudentAddEventHandler = studentAddEventHandler;

        public async ValueTask PublishStudentAddEventAsync(Student student) =>
            await StudentAddEventHandler(student);
    }
}
