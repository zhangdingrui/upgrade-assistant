﻿using System;

namespace AspNetMigrator
{
    public record NuGetReference(string Name, string Version)
    {
        public bool HasWildcardVersion => Version.Equals("*", StringComparison.OrdinalIgnoreCase);

        public override string ToString()
        {
            return $"{Name}, Version={Version}";
        }

        public string? PrivateAssets { get; set; }
    }
}
