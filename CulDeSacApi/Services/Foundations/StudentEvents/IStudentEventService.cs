// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CulDeSacApi.Models.Students;

namespace CulDeSacApi.Services.Foundations.StudentEvents
{
    public interface IStudentEventService
    {
        void SubscribeToStudentAddEvent(Func<Student, ValueTask<Student>> studentEventHandler);
    }
}
