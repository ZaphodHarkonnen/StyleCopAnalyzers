﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;

    internal partial struct SingleVariableDesignationSyntaxWrapper : ISyntaxWrapper<CSharpSyntaxNode>
    {
        public SingleVariableDesignationSyntaxWrapper WithIdentifier(SyntaxToken identifier)
        {
            return new SingleVariableDesignationSyntaxWrapper(WithIdentifierAccessor(this.SyntaxNode, identifier));
        }
    }
}
