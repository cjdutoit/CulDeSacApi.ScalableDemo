﻿// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System;
using CulDeSacApi.Models.LibraryAccounts;

namespace CulDeSacApi.Models.Students
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public LibraryAccount LibraryAccount { get; set; }
    }
}
