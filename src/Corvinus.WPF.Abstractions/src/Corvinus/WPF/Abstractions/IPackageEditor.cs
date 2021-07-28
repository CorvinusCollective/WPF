// <copyright file="IPackageEditor.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Abstractions
{
    /// <summary>
    /// Package editor interface.
    /// </summary>
    public interface IPackageEditor
    {
        /// <summary>
        /// Opens package.
        /// </summary
        /// <returns>File path of the opened file.</returns>
        string OpenPackage();

        /// <summary>
        /// Saves package with a specified name.
        /// </summary>
        /// <returns>File path of the saved file.</returns>
        string SavePackageAs();

        /// <summary>
        /// Saves package.
        /// </summary>
        /// <returns>True if success, False otherwise.</returns>
        bool SavePackage();
    }
}
