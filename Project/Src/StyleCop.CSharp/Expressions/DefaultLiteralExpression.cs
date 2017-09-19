// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultValueExpression.cs" company="https://github.com/StyleCop">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
// <summary>
//   An expression representing a default value operation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace StyleCop.CSharp
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// An expression representing a default value operation.
    /// </summary>
    /// <subcategory>expression</subcategory>
    public sealed class DefaultLiteralExpression : Expression, ICodePart
    {
        #region Fields

        /// <summary>
        /// The parent of the parameter.
        /// </summary>
        private readonly Reference<ICodePart> parent;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the DefaultLiteralExpression class.
        /// </summary>
        /// <param name="tokens">
        /// The list of tokens that form the expression.
        /// </param>
        /// <param name="parent">
        /// The parent reference of this expression.
        /// </param>
        internal DefaultLiteralExpression(CsTokenList tokens, Reference<ICodePart> parent)
            : base(ExpressionType.DefaultValue, tokens)
        {
            Param.AssertNotNull(tokens, "tokens");
            
            this.parent = parent;
        }

        #endregion

        #region Explicit Interface Properties

        /// <summary>
        /// Gets the actual parent ICodePart of this expression. Normally a Parameter.
        /// </summary>
        ICodePart ICodePart.Parent
        {
            get
            {
                return this.parent.Target;
            }
        }

        #endregion
    }
}