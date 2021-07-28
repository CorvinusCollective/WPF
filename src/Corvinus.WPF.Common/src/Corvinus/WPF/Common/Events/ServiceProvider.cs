// <copyright file="ServiceProvider.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Events
{
    using System;
    using System.Windows.Markup;

    /// <summary>
    /// Service Provider.
    /// </summary>
    internal class ServiceProvider : IServiceProvider, IProvideValueTarget
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvider"/> class.
        /// </summary>
        /// <param name="targetObject">The target object.</param>
        /// <param name="targetProperty">The target property.</param>
        public ServiceProvider(object targetObject, object targetProperty)
        {
            TargetObject = targetObject;
            TargetProperty = targetProperty;
        }

        /// <summary>
        /// Gets target Object for the <see cref="ServiceProvider."/>.
        /// </summary>
        public object TargetObject { get; }

        /// <summary>
        /// Gets target Property for the <see cref="ServiceProvider."/>.
        /// </summary>
        public object TargetProperty { get; }

        /// <summary>
        /// Gets a service instance of a type.
        /// </summary>
        /// <param name="serviceType">Type to get an instance of.</param>
        /// <returns>An instance of a service.</returns>
        public object GetService(Type serviceType)
        {
            return serviceType.IsInstanceOfType(this) ? this : null;
        }
    }
}
