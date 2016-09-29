﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.SymbolSearch
{
    internal static class SymbolSearchOptions
    {
        public static readonly Option<bool> Enabled = new Option<bool>(nameof(SymbolSearchOptions), nameof(Enabled), defaultValue: true);

        public static PerLanguageOption<bool> SuggestForTypesInReferenceAssemblies =
            new PerLanguageOption<bool>(nameof(SymbolSearchOptions), nameof(SuggestForTypesInReferenceAssemblies), defaultValue: true,
                storageLocations: new RoamingProfileStorageLocation("TextEditor.%LANGUAGE%.Specific.SuggestForTypesInReferenceAssemblies"));

        public static PerLanguageOption<bool> SuggestForTypesInNuGetPackages =
            new PerLanguageOption<bool>(nameof(SymbolSearchOptions), nameof(SuggestForTypesInNuGetPackages), defaultValue: true,
                storageLocations: new RoamingProfileStorageLocation("TextEditor.%LANGUAGE%.Specific.SuggestForTypesInNuGetPackages"));
    }
}