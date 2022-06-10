// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CulDeSacApi.Models.LibraryAccounts;
using CulDeSacApi.Services.Foundations.LibraryAccounts;
using CulDeSacApi.Services.Foundations.StudentEvents;

namespace CulDeSacApi.Services.Orchestrations.LibraryAccounts
{
    public class LibraryAccountOrchestrationService : ILibraryAccountOrchestrationService
    {
        private readonly ILibraryAccountService libraryAccountService;
        private readonly IStudentEventService studentEventService;

        public LibraryAccountOrchestrationService(
            ILibraryAccountService libraryAccountService,
            IStudentEventService studentEventService)
        {
            this.libraryAccountService = libraryAccountService;
            this.studentEventService = studentEventService;
        }

        public void ListenToLocalStudentEvent()
        {
            this.studentEventService.SubscribeToStudentAddEvent(async (student) =>
            {
                var libraryAccount = new LibraryAccount
                {
                    Id = Guid.NewGuid(),
                    StudentId = student.Id
                };

                await CreateLibraryAccountAsync(libraryAccount);

                return student;
            });
        }

        public async ValueTask<LibraryAccount> CreateLibraryAccountAsync(LibraryAccount libraryAccount)
        {
            throw new System.NotImplementedException();
        }
    }
}
