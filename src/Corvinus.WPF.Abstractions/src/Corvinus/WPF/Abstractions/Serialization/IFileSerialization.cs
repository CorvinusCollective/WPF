// <copyright file="IFileSerialization.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Abstractions
{
    /// <summary>
    /// Provides serialization of objects to/from files.
    /// </summary>
    public interface IFileSerialization
    {
        /// <summary>
        /// Deserializes an object from a file.
        /// </summary>
        /// <typeparam name="T">Type of object to deserialize.</typeparam>
        /// <param name="filePath">Source file path.</param>
        /// <returns>Deserialized object.</returns>
        T DeserializeFromFile<T>(string filePath);

        /// <summary>
        /// Serializes an object to a file.
        /// </summary>
        /// <param name="objectToSerialize">Object to serialize.</param>
        /// <param name="filePath">Destination file path.</param>
        /// <param name="append">If true and the file exists it will be appended to, 
        /// otherwise it will be overwritten.</param>
        void SerializeToFile(object objectToSerialize, string filePath, bool append = false);
    }
}
