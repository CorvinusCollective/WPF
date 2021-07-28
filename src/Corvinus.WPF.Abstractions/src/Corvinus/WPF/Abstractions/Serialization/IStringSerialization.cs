// <copyright file="IStringSerialization.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Abstractions
{
    /// <summary>
    /// Provides serialization of objects to/from strings.
    /// </summary>
    public interface IStringSerialization
    {
        /// <summary>
        /// Deserializes an object from a string.
        /// </summary>
        /// <typeparam name="T">Type of object to deserialize.</typeparam>
        /// <param name="stringToDeserialize">Input string.</param>
        /// <returns>Deserialized object.</returns>
        T DeserializeFromString<T>(string stringToDeserialize);

        /// <summary>
        /// Serializes an object to a string.
        /// </summary>
        /// <param name="objectToSerialize">Object to serialize.</param>
        /// <returns>String the object was serialized to.</returns>
        string SerializeToString(object objectToSerialize);
    }
}
