using Microsoft.WindowsAzure.Storage;

namespace Azure.Storage.Connection.GetCloudStorageAccount
{
    /// <summary>Function returns an instance of Microsoft Azure CloudStorageAccount using the given connection string</summary>
    public static class CloudStorageAccountGetter
    {
        /// <summary>Returns an instance of Microsoft Azure CloudStorageAccount using the given connection string</summary>
        public static CloudStorageAccount StorageAccount(string connectionString) => CloudStorageAccount.Parse(connectionString);
    }
}
