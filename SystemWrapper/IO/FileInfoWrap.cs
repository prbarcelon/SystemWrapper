using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileInfo"/> class.
    /// </summary>
    [Serializable, ComVisible(true)]
    public class FileInfoWrap : FileSystemInfo, IFileInfoWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
        public FileInfoWrap(FileInfo fileInfo)
        {
            FileInfoInstance = fileInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
        public FileInfoWrap(string fileName)
        {
            FileInfoInstance = new FileInfo(fileName);
        }

        public IDirectoryInfoWrap Directory
        {
            get { return new DirectoryInfoWrap(FileInfoInstance.Directory); }
        }

        public string DirectoryName
        {
            get { return FileInfoInstance.DirectoryName; }
        }

        public override bool Exists
        {
            get { return FileInfoInstance.Exists; }
        }

        public FileInfo FileInfoInstance { get; private set; }

        public bool IsReadOnly
        {
            get { return FileInfoInstance.IsReadOnly; }
            set { FileInfoInstance.IsReadOnly = value; }
        }

        public long Length
        {
            get { return FileInfoInstance.Length; }
        }

        public override string Name
        {
            get { return FileInfoInstance.Name; }
        }

        public IStreamWriterWrap AppendText()
        {
            return new StreamWriterWrap(FileInfoInstance.AppendText());
        }

        public void Decrypt()
        {
            FileInfoInstance.Decrypt();
        }

        public override void Delete()
        {
            FileInfoInstance.Delete();
        }

        public void Encrypt()
        {
            FileInfoInstance.Encrypt();
        }

        public IFileInfoWrap CopyTo(string destFileName)
        {
            return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName));
        }

        public IFileInfoWrap CopyTo(string destFileName, bool overwrite)
        {
            return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName, overwrite));
        }

        public IFileStreamWrap Create()
        {
            return new FileStreamWrap(FileInfoInstance.Create());
        }

        public IStreamWriterWrap CreateText()
        {
            return new StreamWriterWrap(FileInfoInstance.CreateText());
        }

        public IFileSecurityWrap GetAccessControl()
        {
            return new FileSecurityWrap(FileInfoInstance.GetAccessControl());
        }

        public IFileSecurityWrap GetAccessControl(AccessControlSections includeSections)
        {
            return new FileSecurityWrap(FileInfoInstance.GetAccessControl(includeSections));
        }

        public void MoveTo(string destFileName)
        {
            FileInfoInstance.MoveTo(destFileName);
        }

        public IFileStreamWrap Open(FileMode mode)
        {
            return new FileStreamWrap(FileInfoInstance.Open(mode));
        }

        public IFileStreamWrap Open(FileMode mode, FileAccess access)
        {
            return new FileStreamWrap(FileInfoInstance.Open(mode, access));
        }

        public IFileStreamWrap Open(FileMode mode, FileAccess access, FileShare share)
        {
            return new FileStreamWrap(FileInfoInstance.Open(mode, access, share));
        }

        public IFileStreamWrap OpenRead()
        {
            return new FileStreamWrap(FileInfoInstance.OpenRead());
        }

        public IStreamReaderWrap OpenText()
        {
            return new StreamReaderWrap(FileInfoInstance.OpenText());
        }

        public IFileStreamWrap OpenWrite()
        {
            return new FileStreamWrap(FileInfoInstance.OpenWrite());
        }

        public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName)
        {
            return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName));
        }

        public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
        }

        public void SetAccessControl(IFileSecurityWrap fileSecurity)
        {
            FileInfoInstance.SetAccessControl(fileSecurity.FileSecurityInstance);
        }

        public override string ToString()
        {
            return FileInfoInstance.ToString();
        }

        internal static IFileInfoWrap[] ConvertFileInfoArrayIntoIFileInfoWrapArray(FileInfo[] fileInfos)
        {
            FileInfoWrap[] fileInfoWraps = new FileInfoWrap[fileInfos.Length];
            for (int i = 0; i < fileInfos.Length; i++)
                fileInfoWraps[i] = new FileInfoWrap(fileInfos[i]);
            return fileInfoWraps;
        }
    }
}