// <copyright file="NameManager.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Managers
{
    using System.Collections.Generic;

    /// <summary>
    /// Manages object names for opeartion designer.
    /// </summary>
    public static class NameManager
    {
        private static HashSet<string> _newItemNames = new HashSet<string>();

        private static HashSet<string> _loadedItemNames = new HashSet<string>();

        /// <summary>
        /// Initializes name collection from a loaded operation.
        /// </summary>
        /// <param name="loadedNames">A set of loaded item names.</param>
        public static void Initialize(HashSet<string> loadedNames)
        {
            _loadedItemNames = loadedNames;
        }

        /// <summary>
        /// Generates unique object name.
        /// </summary>
        /// <param name="baseName">Name to use as a base.</param>
        /// <returns>Unique object name.</returns>
        public static string GenerateUniqueName(string baseName)
        {
            int i = 2;
            string result = baseName;

            while (_loadedItemNames.Contains(result) || _newItemNames.Contains(result))
            {
                result = baseName + (i++);
            }

            _newItemNames.Add(result);

            return result;
        }
    }
}
