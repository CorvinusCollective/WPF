// <copyright file="IStreamSerialization.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Abstractions
{
    using System.IO;

    /// <summary>
    /// Provides serialization of objects to/from streams.
    /// </summary>
    public interface IStreamSerialization
    {
        /// <summary>
        /// Deserializes an object from a stream. Will not close the stream.
        /// </summary>
        /// <typeparam name="T">Type of object to deserialize.</typeparam>
        /// <param name="inStream">Input stream.</param>
        /// <returns>Deserialized object.</returns>
        T DeserializeFromStream<T>(Stream inStream);

        /// <summary>
        /// Serializes an object to a stream. Will not close the stream.
        /// </summary>
        /// <param name="objectToSerialize">Object to serialize.</param>
        /// <param name="outStream">Output stream.</param>
        void SerializeToStream(object objectToSerialize, Stream outStream);
    }
}
