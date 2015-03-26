namespace DSmall.Azure.Storage
{
    using Microsoft.WindowsAzure.Storage.Blob;

    /// <summary>The dSmall cloud blob container.</summary>
    public class DSmallCloudBlobContainer : ICloudBlobContainer
    {
        private readonly CloudBlobContainer container;

        /// <summary>Initialises a new instance of the <see cref="DSmallCloudBlobContainer"/> class.</summary>
        /// <param name="container">The container.</param>
        public DSmallCloudBlobContainer(CloudBlobContainer container)
        {
            this.container = container;
        }

        /// <summary>The get block blob reference.</summary>
        /// <param name="blobName">The blob name.</param>
        /// <returns>The <see cref="ICloudBlockBlob"/>.</returns>
        public ICloudBlockBlob GetBlockBlobReference(string blobName)
        {
            return new DSmallCloudBlockBlob(container.GetBlockBlobReference(blobName));
        }

        /// <summary>The create if not exists.</summary>
        public void CreateIfNotExists()
        {
            container.CreateIfNotExists();
        }
    }
}