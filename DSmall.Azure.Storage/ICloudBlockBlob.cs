namespace DSmall.Azure.Storage
{
    using System;

    /// <summary>The cloud block blob interface.</summary>
    public interface ICloudBlockBlob
    {
        /// <summary>Gets the uri.</summary>
        Uri Uri { get; }

        /// <summary>The upload text.</summary>
        /// <param name="toString">The to string.</param>
        void UploadText(string toString);
    }
}