// <copyright file="GeneralAnimationValueAdapter{T}.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Controls.Animation
{
    using System;

    /// <summary>
    /// A GeneralAnimationValueAdapter Generic.
    /// </summary>
    /// <typeparam name="T">Any type to convert.</typeparam>
    internal abstract class GeneralAnimationValueAdapter<T> : AnimationValueAdapter
    {
        private const double SimpleDoubleComparisonEpsilon = 0.000009;
        private double _ratio;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralAnimationValueAdapter{T}"/> class.
        /// </summary>
        /// <param name="d">A <see cref="DoubleAnimationDimension"/> value.</param>
        /// <param name="instance">An instance of the generic type passed in.</param>
        internal GeneralAnimationValueAdapter(DoubleAnimationDimension d, T instance)
            : base(d)
        {
            Instance = instance;

            InitialValue = StripMagicNumberOff(GetValue());
            _ratio = InitialValue / 100;
        }

        /// <summary>
        /// Gets or sets an instance of the generic type passed in.
        /// </summary>
        protected T Instance { get; set; }

        /// <summary>
        /// Gets or sets the initial value as a <see cref="double"/>.
        /// </summary>
        protected double InitialValue { get; set; }

        /// <summary>
        /// Gets the dimension from a number provided.
        /// </summary>
        /// <param name="number">Input parameter to determine the new dimension.</param>
        /// <returns>A <see cref="DoubleAnimationDimension"/> value.</returns>
        internal static DoubleAnimationDimension? GetDimensionFromMagicNumber(double number)
        {
            double floor = Math.Floor(number);
            double remainder = number - floor;

            if (remainder >= .1 - SimpleDoubleComparisonEpsilon && remainder <= .1 + SimpleDoubleComparisonEpsilon)
            {
                return DoubleAnimationDimension.Width;
            }

            if (remainder >= .2 - SimpleDoubleComparisonEpsilon && remainder <= .2 + SimpleDoubleComparisonEpsilon)
            {
                return DoubleAnimationDimension.Height;
            }

            return null;
        }

        /// <summary>
        /// Strips the magic number off.
        /// </summary>
        /// <param name="number">The number to base the calucation off of.</param>
        /// <returns>A value as a <see cref="double"/>.</returns>
        internal double StripMagicNumberOff(double number)
        {
            return Dimension == DoubleAnimationDimension.Width ? number - .1 : number - .2;
        }

        /// <summary>
        /// Updates the object with new dimension based on a width and height parameters.
        /// </summary>
        /// <param name="width">The width to use for updating the dimension.</param>
        /// <param name="height">The height to use for updating the dimension.</param>
        internal override void UpdateWithNewDimension(double width, double height)
        {
            double size = Dimension == DoubleAnimationDimension.Width ? width : height;
            UpdateValue(size);
        }

        /// <summary>
        /// Abstract method for GetValue.
        /// </summary>
        /// <returns>A result of type <see cref="double"/>.</returns>
        protected abstract double GetValue();

        /// <summary>
        /// Abstract method for SetValue.
        /// </summary>
        /// <param name="newValue">The new value to set.</param>
        protected abstract void SetValue(double newValue);

        private void UpdateValue(double sizeToUse)
        {
            SetValue(sizeToUse * _ratio);
        }
    }
}
