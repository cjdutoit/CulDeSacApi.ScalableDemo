// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using CulDeSacApi.Brokers.Events;
using CulDeSacApi.Brokers.Storages;
using CulDeSacApi.Models.Students;
using CulDeSacApi.Services.Foundations;
using Moq;
using Tynamix.ObjectFiller;

namespace CulDeSacApi.Tests.Unit.Services.Foundations.Students
{
    public partial class StudentServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<IEventBroker> eventBrokerMock;
        private readonly IStudentService studentService;

        public StudentServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.eventBrokerMock = new Mock<IEventBroker>();

            this.studentService = new StudentService(
                storageBroker: this.storageBrokerMock.Object,
                eventBroker: this.eventBrokerMock.Object);
        }

        private static Student CreateRandomStudent() =>
            CreateStudentFiller().Create();

        private static Filler<Student> CreateStudentFiller() =>
            new Filler<Student>();
    }
}
