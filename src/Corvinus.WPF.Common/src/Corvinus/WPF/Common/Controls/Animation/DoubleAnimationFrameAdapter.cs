// <copyright file="DoubleAnimationFrameAdapter.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Controls.Animation
{
    using System.Windows.Media.Animation;

    /// <summary>
    /// DoubleAnimationFrameAdapter.
    /// </summary>
    internal class DoubleAnimationFrameAdapter : GeneralAnimationValueAdapter<DoubleKeyFrame>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleAnimationFrameAdapter"/> class.
        /// </summary>
        /// <param name="dimension">The dimension of the animation.</param>
        /// <param name="frame">The animation instance.</param>
        internal DoubleAnimationFrameAdapter(DoubleAnimationDimension dimension, DoubleKeyFrame frame)
            : base(dimension, frame)
        {
        }

        /// <inheritdoc/>
        protected override double GetValue()
        {
            return Instance.Value;
        }

        /// <inheritdoc/>
        protected override void SetValue(double newValue)
        {
            Instance.Value = newValue;
        }
    }
}
