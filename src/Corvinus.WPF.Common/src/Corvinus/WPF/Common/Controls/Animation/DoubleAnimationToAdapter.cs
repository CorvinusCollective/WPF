// <copyright file="DoubleAnimationToAdapter.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Controls.Animation
{
    using System.Windows.Media.Animation;

    /// <summary>
    /// DoubleAnimationToAdapter.
    /// </summary>
    internal class DoubleAnimationToAdapter : GeneralAnimationValueAdapter<DoubleAnimation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleAnimationToAdapter"/> class.
        /// </summary>
        /// <param name="dimension">The dimension of the animation.</param>
        /// <param name="instance">The animation instance.</param>
        internal DoubleAnimationToAdapter(DoubleAnimationDimension dimension, DoubleAnimation instance)
            : base(dimension, instance)
        {
        }

        /// <inheritdoc/>
        protected override double GetValue()
        {
            return (double)Instance.To;
        }

        /// <inheritdoc/>
        protected override void SetValue(double newValue)
        {
            Instance.To = newValue;
        }
    }
}
