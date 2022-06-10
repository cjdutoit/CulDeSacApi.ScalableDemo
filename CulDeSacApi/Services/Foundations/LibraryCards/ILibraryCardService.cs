// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CulDeSacApi.Models.LibraryCards;

namespace CulDeSacApi.Services.Foundations.LibraryCards
{
    public interface ILibraryCardService
    {
        ValueTask<LibraryCard> AddLibraryCardAsync(LibraryCard libraryCard);
    }
}
