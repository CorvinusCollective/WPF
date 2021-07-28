// <copyright file="DependencyTarget.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common
{
    using System.Windows;

    /// <summary>
    /// Dependency Target.
    /// </summary>
    internal class DependencyTarget : DependencyObject
    {
        /// <summary>
        /// A DependencyProperty containing the Value.
        /// </summary>
        internal static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(object), typeof(DependencyTarget));

        /// <summary>
        /// Gets or sets a backer property for the DependencyProperty.
        /// </summary>
        internal object Value
        {
            get => GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}
