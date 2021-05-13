﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace Microsoft.DotNet.UpgradeAssistant.Extensions
{
    public interface IExtension
    {
        string Name { get; }

        IFileProvider Files { get; }

        T? GetOptions<T>(string sectionName);
    }
}