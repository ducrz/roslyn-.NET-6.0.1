﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;
using System.Threading.Tasks;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.Indentation;
using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Formatting
{
    internal interface ISyntaxFormattingService : ISyntaxFormatting, ILanguageService
    {
        Task<bool> ShouldFormatOnTypedCharacterAsync(Document document, char typedChar, int caretPosition, CancellationToken cancellationToken);
        Task<ImmutableArray<TextChange>> GetFormattingChangesOnTypedCharacterAsync(Document document, int caretPosition, IndentationOptions indentationOptions, CancellationToken cancellationToken);
        Task<ImmutableArray<TextChange>> GetFormattingChangesOnPasteAsync(Document document, TextSpan textSpan, SyntaxFormattingOptions options, CancellationToken cancellationToken);
    }
}
