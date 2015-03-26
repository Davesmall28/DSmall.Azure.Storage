namespace DSmall.Azure.Storage
{
    /// <summary>The cloud storage account interface.</summary>
    public interface ICloudStorageAccount
    {
        /// <summary>The create cloud blob client.</summary>
        /// <returns>The <see cref="ICloudBlobClient"/>.</returns>
        ICloudBlobClient CreateCloudBlobClient();
    }
}