namespace DSmall.Azure.Storage
{
    using Microsoft.WindowsAzure.Storage.Queue;

    /// <summary>The CloudQueue interface.</summary>
    public interface ICloudQueue
    {
        /// <summary>The add message.</summary>
        /// <param name="cloudQueueMessage">The cloud queue message.</param>
        void AddMessage(CloudQueueMessage cloudQueueMessage);


        /// <summary>The get message.</summary>
        /// <returns>The <see cref="CloudQueueMessage"/>.</returns>
        CloudQueueMessage GetMessage();


        /// <summary>The peek message.</summary>
        /// <returns>The <see cref="CloudQueueMessage"/>.</returns>
        CloudQueueMessage PeekMessage();


        /// <summary>The delete message.</summary>
        /// <param name="cloudQueueMessage">The cloud queue message.</param>
        void DeleteMessage(CloudQueueMessage cloudQueueMessage);
    }
}