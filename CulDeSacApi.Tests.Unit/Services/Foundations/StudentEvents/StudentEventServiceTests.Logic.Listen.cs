// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CulDeSacApi.Models.Students;
using Moq;
using Xunit;

namespace CulDeSacApi.Tests.Unit.Services.Foundations.StudentEvents
{
    public partial class StudentEventServiceTests
    {
        [Fact]
        public void ShouldSubscribeToStudentEvent()
        {
            // given
            var studentEventHandlerMock =
                new Mock<Func<Student, ValueTask<Student>>>();

            // when
            this.studentEventService.SubscribeToStudentAddEvent(
                studentEventHandlerMock.Object);

            // then
            this.eventBrokerMock.Verify(broker =>
                broker.SubscribeToStudentAddEvent(
                    studentEventHandlerMock.Object),
                        Times.Once);

            this.eventBrokerMock.VerifyNoOtherCalls();
        }
    }
}
