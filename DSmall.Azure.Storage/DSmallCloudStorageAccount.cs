namespace DSmall.Azure.Storage
{
    using Microsoft.Azure;
    using Microsoft.WindowsAzure.Storage;

    /// <summary>The dSmall cloud storage account.</summary>
    public class DSmallCloudStorageAccount : ICloudStorageAccount
    {
        private readonly CloudStorageAccount cloudStorageAccount;

        /// <summary>Initialises a new instance of the <see cref="DSmallCloudStorageAccount"/> class.</summary>
        public DSmallCloudStorageAccount()
        {
            cloudStorageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
        }

        /// <summary>Initialises a new instance of the <see cref="DSmallCloudStorageAccount"/> class.</summary>
        /// <param name="cloudStorageAccount">The cloud storage account.</param>
        public DSmallCloudStorageAccount(CloudStorageAccount cloudStorageAccount)
        {
            this.cloudStorageAccount = cloudStorageAccount;
        }

        /// <summary>The create cloud blob client.</summary>
        /// <returns>The <see cref="ICloudBlobClient"/>.</returns>
        public ICloudBlobClient CreateCloudBlobClient()
        {
            return new DSmallCloudBlobClient(cloudStorageAccount.CreateCloudBlobClient());
        }
    }
}