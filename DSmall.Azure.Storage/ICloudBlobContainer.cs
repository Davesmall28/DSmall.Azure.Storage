namespace DSmall.Azure.Storage
{
    using Microsoft.WindowsAzure.Storage.Blob;

    /// <summary>The cloud blob container interface.</summary>
    public interface ICloudBlobContainer
    {
        /// <summary>The get block blob reference.</summary>
        /// <param name="blobName">The blob name.</param>
        /// <returns>The <see cref="ICloudBlockBlob"/>.</returns>
        ICloudBlockBlob GetBlockBlobReference(string blobName);

        /// <summary>The create if not exists.</summary>
        void CreateIfNotExists();

        /// <summary>The set permissions.</summary>
        /// <param name="permissions">The permissions.</param>
        void SetPermissions(BlobContainerPermissions permissions);
    }
}