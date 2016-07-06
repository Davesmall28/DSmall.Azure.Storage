namespace DSmall.Azure.Storage
{
    using System;
    using Microsoft.WindowsAzure.Storage.Queue;

    /// <summary>The dSmall cloud queue message.</summary>
    public class DSmallCloudQueueMessage : ICloudQueueMessage
    {
        private readonly CloudQueueMessage cloudQueueMessage;
        
        /// <summary>Initialises a new instance of the <see cref="DSmallCloudQueueMessage"/> class.</summary>
        /// <param name="cloudQueueMessage">The cloud queue message.</param>
        public DSmallCloudQueueMessage(CloudQueueMessage cloudQueueMessage)
        {
            this.cloudQueueMessage = cloudQueueMessage;
        }

        /// <summary>Gets the as bytes.</summary>
        public byte[] AsBytes
        {
            get
            {
                return cloudQueueMessage.AsBytes;
            }
        }

        /// <summary>Gets the as string.</summary>
        public string AsString
        {
            get
            {
                return cloudQueueMessage.AsString;
            }
        }

        /// <summary>Gets the dequeue count.</summary>
        public int DequeueCount
        {
            get
            {
                return cloudQueueMessage.DequeueCount;
            }
        }

        /// <summary>Gets the expiration time.</summary>
        public DateTimeOffset? ExpirationTime
        {
            get
            {
                return cloudQueueMessage.ExpirationTime;
            }
        }

        /// <summary>Gets the id.</summary>
        public string Id
        {
            get
            {
                return cloudQueueMessage.Id;
            }
        }

        /// <summary>Gets the insertion time.</summary>
        public DateTimeOffset? InsertionTime
        {
            get
            {
                return cloudQueueMessage.InsertionTime;
            }
        }

        /// <summary>Gets the next visible time.</summary>
        public DateTimeOffset? NextVisibleTime
        {
            get
            {
                return cloudQueueMessage.NextVisibleTime;
            }
        }

        /// <summary>Gets the pop receipt.</summary>
        public string PopReceipt
        {
            get
            {
                return cloudQueueMessage.PopReceipt;
            }
        }

        /// <summary>The set message content.</summary>
        /// <param name="content">The content.</param>
        public void SetMessageContent(byte[] content)
        {
            cloudQueueMessage.SetMessageContent(content);
        }

        /// <summary>The set message content.</summary>
        /// <param name="content">The content.</param>
        public void SetMessageContent(string content)
        {
            cloudQueueMessage.SetMessageContent(content);
        }
    }
}