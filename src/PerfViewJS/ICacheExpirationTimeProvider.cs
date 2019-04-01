﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PerfViewJS
{
    using System;

    public interface ICacheExpirationTimeProvider
    {
        TimeSpan Expiration { get; }
    }
}