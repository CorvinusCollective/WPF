// <copyright file="EventSenderExtension.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Events
{
    using System;
    using System.Windows.Markup;

    /// <summary>
    /// Event Sender Extension.
    /// </summary>
    public class EventSenderExtension : MarkupExtension
    {
        /// <summary>
        /// Provides a specific value from the IServiceProvider.
        /// </summary>
        /// <param name="serviceProvider">An instance of the interface <see cref="IServiceProvider"/>.</param>
        /// <returns>Currently returns this.</returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
