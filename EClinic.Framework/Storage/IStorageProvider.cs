using System.IO;
using EClinic.Framework.DependencyInjection;

namespace EClinic.Framework.Storage
{
    public interface IStorageProvider : IDependency
    {
        FileInfo CreateFile(string path);
        bool FileExists(string path);
        bool FolderExists(string path);
        FileInfo GetFile(string path);
        string GetFullStoragePath(string path);
        void SaveFileStream(string path, Stream inputStream);
        void DeleteFile(string path);
    }
}
