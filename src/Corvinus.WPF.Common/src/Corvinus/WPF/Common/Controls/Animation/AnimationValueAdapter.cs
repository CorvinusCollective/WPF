// <copyright file="AnimationValueAdapter.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Controls.Animation
{
    /// <summary>
    /// Animation Value Adapter.
    /// </summary>
    internal abstract class AnimationValueAdapter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationValueAdapter"/> class.
        /// </summary>
        /// <param name="dimension">A value of type <see cref="DoubleAnimationDimension"/>.</param>
        internal AnimationValueAdapter(DoubleAnimationDimension dimension)
        {
            Dimension = dimension;
        }

        /// <summary>
        /// Gets or sets the Dimension.
        /// </summary>
        internal DoubleAnimationDimension Dimension { get; set; }

        /// <summary>
        /// Gets or sets the OriginalValue.
        /// </summary>
        protected internal double OriginalValue { get; set; }

        /// <summary>
        /// Updates value with a new dimension.
        /// </summary>
        /// <param name="width">Width of the new dimension.</param>
        /// <param name="height">Height of the new dimension.</param>
        internal abstract void UpdateWithNewDimension(double width, double height);
    }
}
