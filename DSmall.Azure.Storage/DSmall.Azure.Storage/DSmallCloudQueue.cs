namespace DSmall.Azure.Storage
{
    using Microsoft.WindowsAzure.Storage.Queue;

    /// <summary>The dSmall cloud queue.</summary>
    public class DSmallCloudQueue : ICloudQueue
    {
        private readonly CloudQueue cloudQueue;

        /// <summary>Initialises a new instance of the <see cref="DSmallCloudQueue"/> class.</summary>
        /// <param name="cloudQueue">The cloud queue.</param>
        public DSmallCloudQueue(CloudQueue cloudQueue)
        {
            this.cloudQueue = cloudQueue;
        }

        /// <summary>The add message.</summary>
        /// <param name="cloudQueueMessage">The cloud queue message.</param>
        public void AddMessage(CloudQueueMessage cloudQueueMessage)
        {
            cloudQueue.AddMessage(cloudQueueMessage);
        }

        /// <summary>The get message.</summary>
        /// <returns>The <see cref="CloudQueueMessage"/>.</returns>
        public CloudQueueMessage GetMessage()
        {
            // return new DSmallCloudQueueMessage(cloudQueue.GetMessage());
            return cloudQueue.GetMessage();
        }

        /// <summary>The peek message.</summary>
        /// <returns>The <see cref="CloudQueueMessage"/>.</returns>
        public CloudQueueMessage PeekMessage()
        {
            return cloudQueue.PeekMessage();
        }

        /// <summary>The delete message.</summary>
        /// <param name="cloudQueueMessage">The cloud queue message.</param>
        public void DeleteMessage(CloudQueueMessage cloudQueueMessage)
        {
            cloudQueue.DeleteMessage(cloudQueueMessage);
        }
    }
}