﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Css;
    using AngleSharp.Extensions;
    using System;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/right
    /// </summary>
    sealed class CssRightProperty : CssProperty
    {
        #region ctor

        internal CssRightProperty(CssStyleDeclaration rule)
            : base(PropertyNames.Right, rule, PropertyFlags.Unitless | PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return null;
        }

        protected override Object Compute(IElement element)
        {
            return Converters.AutoLengthOrPercentConverter.Convert(Value);
        }

        protected override Boolean IsValid(ICssValue value)
        {
            return Converters.AutoLengthOrPercentConverter.Validate(value);
        }

        #endregion
    }
}
