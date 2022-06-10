// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CulDeSacApi.Models.LibraryAccounts;

namespace CulDeSacApi.Services.Orchestrations.LibraryAccounts
{
    public interface ILibraryAccountOrchestrationService
    {
        void ListenToLocalStudentEvent();
        ValueTask<LibraryAccount> CreateLibraryAccountAsync(LibraryAccount libraryAccount);
    }
}
