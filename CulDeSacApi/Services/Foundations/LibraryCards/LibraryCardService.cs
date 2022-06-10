﻿// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CulDeSacApi.Brokers.Storages;
using CulDeSacApi.Models.LibraryCards;

namespace CulDeSacApi.Services.Foundations.LibraryCards
{
    public class LibraryCardService : ILibraryCardService
    {
        private readonly IStorageBroker storageBroker;

        public LibraryCardService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<LibraryCard> AddLibraryCardAsync(LibraryCard libraryCard) =>
            throw new NotImplementedException();
    }
}
