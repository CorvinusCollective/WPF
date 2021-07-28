// <copyright file="RelativeAnimatingContentControl.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Controls
{
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using Corvinus.WPF.Common.Controls.Animation;

    /// <summary>
    /// A control that allows you to animate content relative to a specific area.
    /// </summary>
    public class RelativeAnimatingContentControl : ContentControl
    {
        private double _knownWidth;
        private double _knownHeight;
        private List<AnimationValueAdapter> _specialAnimations;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeAnimatingContentControl"/> class.
        /// </summary>
        public RelativeAnimatingContentControl()
        {
            SizeChanged += OnSizeChanged;
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e != null && e.NewSize.Height > 0 && e.NewSize.Width > 0)
            {
                _knownWidth = e.NewSize.Width;
                _knownHeight = e.NewSize.Height;

                Clip = new RectangleGeometry { Rect = new Rect(0, 0, _knownWidth, _knownHeight), };

                UpdateAnyAnimationValues();
            }
        }

        private void UpdateAnyAnimationValues()
        {
            if (_knownHeight > 0 && _knownWidth > 0)
            {
                if (_specialAnimations == null)
                {
                    _specialAnimations = new List<AnimationValueAdapter>();

                    foreach (VisualStateGroup group in VisualStateManager.GetVisualStateGroups(this))
                    {
                        if (group == null)
                        {
                            continue;
                        }

                        foreach (VisualState state in group.States)
                        {
                            if (state != null)
                            {
                                Storyboard sb = state.Storyboard;
                                if (sb != null)
                                {
                                    foreach (Timeline timeline in sb.Children)
                                    {
                                        DoubleAnimation da = timeline as DoubleAnimation;
                                        DoubleAnimationUsingKeyFrames dakeys = timeline as DoubleAnimationUsingKeyFrames;
                                        if (da != null)
                                        {
                                            ProcessDoubleAnimation(da);
                                        }
                                        else if (dakeys != null)
                                        {
                                            ProcessDoubleAnimationWithKeys(dakeys);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                UpdateKnownAnimations();
            }
        }

        private void UpdateKnownAnimations()
        {
            foreach (AnimationValueAdapter adapter in _specialAnimations)
            {
                adapter.UpdateWithNewDimension(_knownWidth, _knownHeight);
            }
        }

        private void ProcessDoubleAnimationWithKeys(DoubleAnimationUsingKeyFrames da)
        {
            foreach (DoubleKeyFrame frame in da.KeyFrames)
            {
                var d = DoubleAnimationFrameAdapter.GetDimensionFromMagicNumber(frame.Value);
                if (d.HasValue)
                {
                    _specialAnimations.Add(new DoubleAnimationFrameAdapter(d.Value, frame));
                }
            }
        }

        private void ProcessDoubleAnimation(DoubleAnimation da)
        {
            if (da.To.HasValue)
            {
                var d = DoubleAnimationToAdapter.GetDimensionFromMagicNumber(da.To.Value);
                if (d.HasValue)
                {
                    _specialAnimations.Add(new DoubleAnimationToAdapter(d.Value, da));
                }
            }

            if (da.From.HasValue)
            {
                var d = DoubleAnimationFromAdapter.GetDimensionFromMagicNumber(da.To.Value);
                if (d.HasValue)
                {
                    _specialAnimations.Add(new DoubleAnimationFromAdapter(d.Value, da));
                }
            }
        }
    }
}
