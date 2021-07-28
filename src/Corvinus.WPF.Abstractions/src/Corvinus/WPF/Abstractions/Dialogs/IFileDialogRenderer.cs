﻿// <copyright file="IFileDialogRenderer.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Abstractions
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for Open/Save File dialogs.
    /// </summary>
    public interface IFileDialogRenderer
    {
        /// <summary>
        /// Shows "Open File" dialog.
        /// </summary>
        /// <param name="title">Dialog title.</param>
        /// <param name="defaultExtension">Default file extension.</param>
        /// <param name="defaultFilterName">Default file extension name.</param>
        /// <returns>Selected file path or null if none selected.</returns>
        string OpenFile(string title, string defaultExtension, string defaultFilterName);

        /// <summary>
        /// Shows "Open File" dialog.
        /// </summary>
        /// <param name="title">Dialog title.</param>
        /// <param name="defaultExtension">Default file extension.</param>
        /// <param name="filters">The list of file filters represented as pairs of (filter caption, file extension).</param>
        /// <returns>Selected file path or null if none selected.</returns>
        string OpenFile(string title, string defaultExtension, IEnumerable<(string, string)> filters);

        /// <summary>
        /// Shows "Save File" dialog.
        /// </summary>
        /// <param name="title">Dialog title.</param>
        /// <param name="defaultExtension">Default file extensio.</param>
        /// <param name="defaultFilterName">Default file extension name.</param>
        /// <param name="defaultFileName">Default file name.</param>
        /// <returns>Selected file path or null if none selected.</returns>
        string SaveFile(string title, string defaultExtension, string defaultFilterName, string defaultFileName);
    }
}
