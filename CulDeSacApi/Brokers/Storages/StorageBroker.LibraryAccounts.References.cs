// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using CulDeSacApi.Models.LibraryAccounts;
using Microsoft.EntityFrameworkCore;

namespace CulDeSacApi.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void AddLibraryAccountsReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibraryAccount>()
                .HasOne(libraryAccount => libraryAccount.Student)
                .WithOne(student => student.LibraryAccount)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
