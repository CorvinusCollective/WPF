// <copyright file="DoubleAnimationFromAdapter.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Controls.Animation
{
    using System.Windows.Media.Animation;

    /// <summary>
    /// DoubleAnimationFromAdapter.
    /// </summary>
    internal class DoubleAnimationFromAdapter : GeneralAnimationValueAdapter<DoubleAnimation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleAnimationFromAdapter"/> class.
        /// </summary>
        /// <param name="dimension">The dimension of the animation.</param>
        /// <param name="instance">The animation instance.</param>
        internal DoubleAnimationFromAdapter(DoubleAnimationDimension dimension, DoubleAnimation instance)
            : base(dimension, instance)
        {
        }

        /// <inheritdoc/>
        protected override double GetValue()
        {
            return (double)Instance.From;
        }

        /// <inheritdoc/>
        protected override void SetValue(double newValue)
        {
            Instance.From = newValue;
        }
    }
}
