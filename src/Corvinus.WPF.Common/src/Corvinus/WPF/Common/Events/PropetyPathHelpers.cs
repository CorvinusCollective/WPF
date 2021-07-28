// <copyright file="PropetyPathHelpers.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Events
{
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// Property Path Helper Class.
    /// </summary>
    public static class PropertyPathHelpers
    {
        /// <summary>
        /// Evaluates a <see cref="PropertyPath"/> and source object to determine the <see cref="DependencyTarget"/>.
        /// </summary>
        /// <param name="path">A <see cref="PropertyPath"/> used for evaluation.</param>
        /// <param name="source">The source <see cref="object"/> used for evaluation.</param>
        /// <returns>An <see cref="object"/> returned from the <see cref="DependencyObject"/> Value property.</returns>
        public static object Evaluate(PropertyPath path, object source)
        {
            var target = new DependencyTarget();
            var binding = new Binding() { Path = path, Source = source, Mode = BindingMode.OneTime };
            BindingOperations.SetBinding(target, DependencyTarget.ValueProperty, binding);

            return target.Value;
        }
    }
}
