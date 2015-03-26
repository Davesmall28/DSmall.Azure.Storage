namespace DSmall.Azure.Storage
{
    using System;
    using Microsoft.WindowsAzure.Storage.Blob;

    /// <summary>The dSmall cloud block blob.</summary>
    public class DSmallCloudBlockBlob : ICloudBlockBlob
    {
        private readonly CloudBlockBlob cloudBlockBlob;

        /// <summary>Initialises a new instance of the <see cref="DSmallCloudBlockBlob"/> class.</summary>
        /// <param name="cloudBlockBlob">The cloud block blob.</param>
        public DSmallCloudBlockBlob(CloudBlockBlob cloudBlockBlob)
        {
            this.cloudBlockBlob = cloudBlockBlob;
        }

        /// <summary>Gets the uri.</summary>
        public Uri Uri
        {
            get
            {
                return cloudBlockBlob.Uri;
            }
        }

        /// <summary>The upload text.</summary>
        /// <param name="content">The content.</param>
        public void UploadText(string content)
        {
            cloudBlockBlob.UploadText(content);
        }
    }
}