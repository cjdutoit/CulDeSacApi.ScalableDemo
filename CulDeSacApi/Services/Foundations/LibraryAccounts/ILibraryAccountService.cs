// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CulDeSacApi.Models.LibraryAccounts;

namespace CulDeSacApi.Services.Foundations.LibraryAccounts
{
    public interface ILibraryAccountService
    {
        ValueTask<LibraryAccount> AddLibraryAccountAsync(LibraryAccount libraryAccount);
    }
}
