// <copyright file="EventArgsExtension.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Events
{
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;
    using System.Windows.Markup;

    /// <summary>
    /// Event Args Extension.
    /// </summary>
    public class EventArgsExtension : MarkupExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgsExtension"/> class.
        /// </summary>
        public EventArgsExtension()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgsExtension"/> class.
        /// </summary>
        /// <param name="path">A <see cref="string"/> containing the PropertyPath information.</param>
        public EventArgsExtension(string path)
        {
            Path = new PropertyPath(path);
        }

        /// <summary>
        /// Gets or sets the PropertyPath of the extension.
        /// </summary>
        public PropertyPath Path { get; set; }

        /// <summary>
        /// Gets or sets the ValueConverter implementing <see cref="IValueConverter"/>.
        /// </summary>
        public IValueConverter Converter { get; set; }

        /// <summary>
        /// Gets or sets the Converter parameter.
        /// </summary>
        public object ConverterParameter { get; set; }

        /// <summary>
        /// Gets or sets the Target Type of the Converter as <see cref="Type"/>.
        /// </summary>
        public Type ConverterTargetType { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="CultureInfo"/> of the Converter.
        /// </summary>
        [TypeConverter(typeof(CultureInfoIetfLanguageTagConverter))]
        public CultureInfo ConverterCulture { get; set; }

        /// <summary>
        /// Provides a specific value from the IServiceProvider.
        /// </summary>
        /// <param name="serviceProvider">An instance of the interface <see cref="IServiceProvider"/>.</param>
        /// <returns>Currently returns this.</returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        /// <summary>
        /// Gest the value of an Event Argument.
        /// </summary>
        /// <param name="eventArgs">Event Argument.</param>
        /// <param name="language">Xml Language.</param>
        /// <returns>An object.</returns>
        internal object GetArgumentValue(EventArgs eventArgs, XmlLanguage language)
        {
            if (Path == null)
            {
                return eventArgs;
            }

            object value = PropertyPathHelpers.Evaluate(Path, eventArgs);

            if (Converter != null)
            {
                value = Converter.Convert(value, ConverterTargetType ?? typeof(object), ConverterParameter, ConverterCulture ?? language.GetSpecificCulture());
            }

            return value;
        }
    }
}
