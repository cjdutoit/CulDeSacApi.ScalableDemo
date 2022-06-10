// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CulDeSacApi.Models.LibraryAccounts;

namespace CulDeSacApi.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<LibraryAccount> InsertLibraryAccountAsync(LibraryAccount libraryAccount);
    }
}
