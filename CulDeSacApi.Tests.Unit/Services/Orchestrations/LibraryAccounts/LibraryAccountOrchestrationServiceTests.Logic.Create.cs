// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CulDeSacApi.Models.LibraryAccounts;
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Xunit;

namespace CulDeSacApi.Tests.Unit.Services.Orchestrations.LibraryAccounts
{
    public partial class LibraryAccountOrchestrationServiceTests
    {
        [Fact]
        public async Task ShouldCreateLibraryAccountAsync()
        {
            // given
            LibraryAccount randomLibraryAccount =
                CreateRandomLibraryAccount();

            LibraryAccount inputLibraryAccount =
                randomLibraryAccount;

            LibraryAccount addedLibraryAccount =
                inputLibraryAccount;

            LibraryAccount expectedLibraryAccount =
                addedLibraryAccount.DeepClone();

            var mockSequence = new MockSequence();

            this.libraryAccountServiceMock.InSequence(mockSequence).Setup(service =>
                service.AddLibraryAccountAsync(inputLibraryAccount))
                    .ReturnsAsync(addedLibraryAccount);

            // when
            LibraryAccount actualLibraryAccount =
                await this.libraryAccountOrchestrationService
                    .CreateLibraryAccountAsync(inputLibraryAccount);

            // then
            actualLibraryAccount.Should().BeEquivalentTo(expectedLibraryAccount);

            this.libraryAccountServiceMock.Verify(service =>
                service.AddLibraryAccountAsync(inputLibraryAccount),
                    Times.Once);

            this.libraryAccountServiceMock.VerifyNoOtherCalls();
        }
    }
}
