// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using CulDeSacApi.Brokers.Events;
using CulDeSacApi.Models.Students;
using CulDeSacApi.Services.Foundations.StudentEvents;
using Moq;
using Tynamix.ObjectFiller;

namespace CulDeSacApi.Tests.Unit.Services.Foundations.StudentEvents
{
    public partial class StudentEventServiceTests
    {
        private readonly Mock<IEventBroker> eventBrokerMock;
        private readonly IStudentEventService studentEventService;

        public StudentEventServiceTests()
        {
            this.eventBrokerMock = new Mock<IEventBroker>();

            this.studentEventService = new StudentEventService(
                eventBroker: this.eventBrokerMock.Object);
        }

        private static Student CreateRandomStudent() =>
            CreateStudentFiller().Create();

        private static Filler<Student> CreateStudentFiller() =>
            new Filler<Student>();
    }
}
