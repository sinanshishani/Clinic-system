using System;
using System.IO;
using EClinic.Framework.Storage.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace EClinic.Framework.Storage
{
    public class FileSystemStorageProvider : IStorageProvider
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment env;

        public string StoragePath => configuration.GetValue("File_System_Storage_Path", "~/Uploads/");

        private string absoluteStoragePath = string.Empty;

        public string AbsoluteStoragePath
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(absoluteStoragePath))
                    return absoluteStoragePath;

                if (IsPathRooted(StoragePath))
                    return absoluteStoragePath = StoragePath;

                return absoluteStoragePath = Path.Combine(env.ContentRootPath, configuration.GetValue("File_System_Storage_Path", "~/Uploads/"));
            }
        }

        public FileSystemStorageProvider(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.configuration = configuration;
            this.env = env;
        }

        public bool FileExists(string path)
        {
            return File.Exists(MapPath(path));
        }

        public bool FolderExists(string path)
        {
            return new DirectoryInfo(MapPath(path)).Exists;
        }

        public string GetFullStoragePath(string path)
        {
            return MapPath(path);
        }

        public FileInfo GetFile(string path)
        {
            return new FileInfo(MapPath(path));
        }

        public FileInfo CreateFile(string path)
        {
            FileInfo fileInfo = GetFile(path);
            if (fileInfo.Exists)
            {
                throw new ArgumentException($"File {fileInfo.Name} already exists");
            }

            // ensure the directory exists
            var dirName = Path.GetDirectoryName(fileInfo.FullName);
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
            File.WriteAllBytes(fileInfo.FullName, new byte[0]);

            return GetFile(fileInfo.FullName);
        }

        public void SaveFileStream(string path, Stream inputStream)
        {
            var newFile = this.GetOrCreateFile(path);

            using (var stream = newFile.OpenWrite())
            {
                if (inputStream.CanSeek)
                {
                    inputStream.Seek(0, SeekOrigin.Begin);
                }

                inputStream.CopyTo(stream);
            }
        }

        public void DeleteFile(string path)
        {
            FileInfo fileInfo = GetFile(path);
            if (!fileInfo.Exists)
            {
                throw new ArgumentException($"File {path} does not exist");
            }

            fileInfo.Delete();
        }

        private string MapPath(string path)
        {
            return string.IsNullOrEmpty(path) ? AbsoluteStoragePath : Path.Combine(AbsoluteStoragePath, NormalizePath(path));
        }

        private string NormalizePath(string path)
        {
            return FixPath(path.TrimStart('/'));
        }

        private static string FixPath(string path)
        {
            return string.IsNullOrEmpty(path)
                       ? ""
                       : Path.DirectorySeparatorChar != '/'
                             ? path.Replace('/', Path.DirectorySeparatorChar)
                             : path;
        }

        private bool IsPathRooted(string path)
        {
            return FixPath(path) == FixPath(Path.GetFullPath(path));
        }
    }
}
