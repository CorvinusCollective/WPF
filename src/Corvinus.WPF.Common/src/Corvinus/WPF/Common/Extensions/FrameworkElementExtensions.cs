// <copyright file="FrameworkElementExtensions.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Extensions
{
    using System.Windows;

    /// <summary>
    /// Presentation extensions.
    /// </summary>
    public static class FrameworkElementExtensions
    {
        /// <summary>
        /// Binds UI element to its view mode.
        /// </summary>
        /// <param name="element">FrameworkElement instance.</param>
        /// <param name="viewmodel">Viewmodel instance.</param>
        public static void BindTo(this FrameworkElement element, object viewmodel)
        {
            element.DataContext = viewmodel;
        }
    }
}
