namespace DSmall.Azure.Storage
{
    /// <summary>The cloud queue client interface.</summary>
    public interface ICloudQueueClient
    {
        /// <summary>The get queue reference.</summary>
        /// <param name="queueName">The queue name.</param>
        /// <returns>The <see cref="ICloudQueue"/>.</returns>
        ICloudQueue GetQueueReference(string queueName);
    }
}
