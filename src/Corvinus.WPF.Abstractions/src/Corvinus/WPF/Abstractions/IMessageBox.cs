// <copyright file="IMessageBox.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Abstractionsv
{
    using System.Windows;

    /// <summary>
    /// Defines interface for showing message boxes.
    /// </summary>
    public interface IMessageBox
    {
        /// <summary>
        /// Shows message box with a question.
        /// </summary>
        /// <param name="message">Message text.</param>
        /// <param name="title">Message box title.</param>
        /// <param name="buttons">Button configuration.</param>
        /// <returns>True for positive answer, False otherwise.</returns>
        bool ShowQuestion(string message, string title, MessageBoxButton buttons = MessageBoxButton.YesNo);

        /// <summary>
        /// Shows message box with a question.
        /// </summary>
        /// <param name="message">Message text.</param>
        /// <param name="title">Message box title.</param>
        void ShowError(string message, string title);
    }
}
