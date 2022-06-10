// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CulDeSacApi.Models.Students;

namespace CulDeSacApi.Brokers.Events
{
    public partial interface IEventBroker
    {
        ValueTask PublishStudentAddEventAsync(Student student);
    }
}
