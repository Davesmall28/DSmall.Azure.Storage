namespace DSmall.Azure.Storage
{
    using Microsoft.WindowsAzure.Storage.Blob;

    /// <summary>The dSmall cloud blob client.</summary>
    public class DSmallCloudBlobClient : ICloudBlobClient
    {
        private readonly CloudBlobClient createCloudBlobClient;

        /// <summary>Initialises a new instance of the <see cref="DSmallCloudBlobClient"/> class.</summary>
        /// <param name="createCloudBlobClient">The create cloud blob client.</param>
        public DSmallCloudBlobClient(CloudBlobClient createCloudBlobClient)
        {
            this.createCloudBlobClient = createCloudBlobClient;
        }

        /// <summary>The get container reference.</summary>
        /// <param name="containerName">The container name.</param>
        /// <returns>The <see cref="ICloudBlobContainer"/>.</returns>
        public ICloudBlobContainer GetContainerReference(string containerName)
        {
            return new DSmallCloudBlobContainer(createCloudBlobClient.GetContainerReference(containerName));
        }
    }
}