namespace DSmall.Azure.Storage
{
    /// <summary>The cloud blob client interface.</summary>
    public interface ICloudBlobClient
    {
        /// <summary>The get container reference.</summary>
        /// <param name="containerName">The container name.</param>
        /// <returns>The <see cref="ICloudBlobContainer"/>.</returns>
        ICloudBlobContainer GetContainerReference(string containerName);
    }
}