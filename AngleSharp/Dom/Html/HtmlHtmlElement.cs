﻿namespace AngleSharp.Dom.Html
{
    using AngleSharp.Html;
    using System;
    
    /// <summary>
    /// Represents the HTML html element.
    /// </summary>
    sealed class HtmlHtmlElement : HtmlElement, IHtmlHtmlElement
    {
        #region ctor

        /// <summary>
        /// Creates a new HTML html tag.
        /// </summary>
        public HtmlHtmlElement(Document owner)
            : base(owner, Tags.Html, NodeFlags.Special | NodeFlags.ImplicitelyClosed | NodeFlags.Scoped | NodeFlags.HtmlTableScoped | NodeFlags.HtmlTableSectionScoped)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value of the manifest attribute.
        /// </summary>
        public String Manifest 
        {
            get { return GetOwnAttribute(AttributeNames.Manifest); }
            set { SetOwnAttribute(AttributeNames.Manifest, value); }
        }

        #endregion
    }
}
