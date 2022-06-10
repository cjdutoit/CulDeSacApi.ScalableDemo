// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CulDeSacApi.Models.Students;

namespace CulDeSacApi.Brokers.Events
{
    public partial interface IEventBroker
    {
        void SubscribeToStudentAddEvent(Func<Student, ValueTask<Student>> studentAddEventHandler);
        ValueTask PublishStudentAddEventAsync(Student student);
    }
}
