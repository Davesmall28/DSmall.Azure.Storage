namespace DSmall.Azure.Storage
{
    using System;

    /// <summary>The cloud queue message interface.</summary>
    public interface ICloudQueueMessage
    {
        /// <summary>Gets the as bytes.</summary>
        byte[] AsBytes { get; }

        /// <summary>Gets the as string.</summary>
        string AsString { get; }

        /// <summary>Gets the dequeue count.</summary>
        int DequeueCount { get; }

        /// <summary>Gets the expiration time.</summary>
        DateTimeOffset? ExpirationTime { get; }

        /// <summary>Gets the id.</summary>
        string Id { get; }

        /// <summary>Gets the insertion time.</summary>
        DateTimeOffset? InsertionTime { get; }

        /// <summary>Gets the next visible time.</summary>
        DateTimeOffset? NextVisibleTime { get; }

        /// <summary>Gets the pop receipt.</summary>
        string PopReceipt { get; }

        /// <summary>The set message content.</summary>
        /// <param name="content">The content.</param>
        void SetMessageContent(byte[] content);

        /// <summary>The set message content.</summary>
        /// <param name="content">The content.</param>
        void SetMessageContent(string content);
    }
}