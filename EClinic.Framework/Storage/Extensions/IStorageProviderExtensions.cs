using System.IO;

namespace EClinic.Framework.Storage.Extensions
{
    public static class IStorageProviderExtensions
    {
        public static FileInfo GetOrCreateFile(this IStorageProvider storageProvider, string path)
        {
            return !storageProvider.FileExists(path) ? storageProvider.CreateFile(path) : storageProvider.GetFile(path);
        }
    }
}
