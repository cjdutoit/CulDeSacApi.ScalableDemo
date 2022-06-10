// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using CulDeSacApi.Models.LibraryAccounts;
using CulDeSacApi.Services.Foundations.LibraryAccounts;
using CulDeSacApi.Services.Foundations.StudentEvents;
using CulDeSacApi.Services.Orchestrations.LibraryAccounts;
using Moq;
using Tynamix.ObjectFiller;

namespace CulDeSacApi.Tests.Unit.Services.Orchestrations.LibraryAccounts
{
    public partial class LibraryAccountOrchestrationServiceTests
    {
        private readonly Mock<ILibraryAccountService> libraryAccountServiceMock;
        private readonly Mock<IStudentEventService> studentEventServiceMock;
        private readonly ILibraryAccountOrchestrationService libraryAccountOrchestrationService;

        public LibraryAccountOrchestrationServiceTests()
        {
            this.libraryAccountServiceMock = new Mock<ILibraryAccountService>(MockBehavior.Strict);
            this.studentEventServiceMock = new Mock<IStudentEventService>(MockBehavior.Strict);

            this.libraryAccountOrchestrationService = new LibraryAccountOrchestrationService(
                libraryAccountService: this.libraryAccountServiceMock.Object,
                studentEventService: this.studentEventServiceMock.Object);
        }

        private static LibraryAccount CreateRandomLibraryAccount() =>
            CreateLibraryAccountFiller().Create();

        private static Filler<LibraryAccount> CreateLibraryAccountFiller() =>
            new Filler<LibraryAccount>();
    }
}
