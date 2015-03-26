namespace DSmall.Azure.Storage
{
    /// <summary>The CloudBlobClient interface.</summary>
    public interface ICloudBlobClient
    {
        /// <summary>The get container reference.</summary>
        /// <param name="containerName">The container name.</param>
        /// <returns>The <see cref="ICloudBlobContainer"/>.</returns>
        ICloudBlobContainer GetContainerReference(string containerName);
    }
}