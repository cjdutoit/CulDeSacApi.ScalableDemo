// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Linq.Expressions;
using CulDeSacApi.Models.LibraryAccounts;
using CulDeSacApi.Models.LibraryCards;
using CulDeSacApi.Services.Foundations.LibraryAccounts;
using CulDeSacApi.Services.Foundations.LibraryCards;
using CulDeSacApi.Services.Foundations.StudentEvents;
using CulDeSacApi.Services.Orchestrations.LibraryAccounts;
using Moq;
using Tynamix.ObjectFiller;

namespace CulDeSacApi.Tests.Unit.Services.Orchestrations.LibraryAccounts
{
    public partial class LibraryAccountOrchestrationServiceTests
    {
        private readonly Mock<ILibraryAccountService> libraryAccountServiceMock;
        private readonly Mock<ILibraryCardService> libraryCardServiceMock;
        private readonly Mock<IStudentEventService> studentEventServiceMock;
        private readonly ILibraryAccountOrchestrationService libraryAccountOrchestrationService;

        public LibraryAccountOrchestrationServiceTests()
        {
            this.libraryAccountServiceMock = new Mock<ILibraryAccountService>(MockBehavior.Strict);
            this.libraryCardServiceMock = new Mock<ILibraryCardService>(MockBehavior.Strict);
            this.studentEventServiceMock = new Mock<IStudentEventService>(MockBehavior.Strict);

            this.libraryAccountOrchestrationService = new LibraryAccountOrchestrationService(
                libraryAccountService: this.libraryAccountServiceMock.Object,
                libraryCardService: this.libraryCardServiceMock.Object,
                studentEventService: this.studentEventServiceMock.Object);
        }

        private static Expression<Func<LibraryCard, bool>> SameLibraryCardAs(LibraryCard expectedLibraryCard)
        {
            return actualLibraryCard =>
                actualLibraryCard.LibraryAccountId == expectedLibraryCard.LibraryAccountId
                && actualLibraryCard.Id != Guid.Empty;
        }

        private static LibraryAccount CreateRandomLibraryAccount() =>
            CreateLibraryAccountFiller().Create();

        private static Filler<LibraryAccount> CreateLibraryAccountFiller() =>
            new Filler<LibraryAccount>();
    }
}
