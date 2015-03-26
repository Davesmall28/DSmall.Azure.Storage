namespace DSmall.Azure.Storage
{
    using Microsoft.WindowsAzure.Storage.Queue;

    /// <summary>The d small cloud queue client.</summary>
    public class DSmallCloudQueueClient : ICloudQueueClient
    {
        private readonly CloudQueueClient cloudQueueClient;

        /// <summary>Initialises a new instance of the <see cref="DSmallCloudQueueClient"/> class.</summary>
        /// <param name="cloudQueueClient">The cloud queue client.</param>
        public DSmallCloudQueueClient(CloudQueueClient cloudQueueClient)
        {
            this.cloudQueueClient = cloudQueueClient;
        }

        /// <summary>The get queue reference.</summary>
        /// <param name="queueName">The queue name.</param>
        /// <returns>The <see cref="ICloudQueue"/>.</returns>
        public ICloudQueue GetQueueReference(string queueName)
        {
            return new DSmallCloudQueue(cloudQueueClient.GetQueueReference(queueName));
        }
    }
}
