﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Npgsql.EntityFrameworkCore.PostgreSQL.FunctionalTests.Utilities
{
    public static class DbContextOptionsBuilderExtensions
    {
        public static NpgsqlDbContextOptionsBuilder ApplyConfiguration(this NpgsqlDbContextOptionsBuilder optionsBuilder)
        {
            return optionsBuilder;
        }
    }
}
