namespace TelerikAcademyLearningSystem.Utilities
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public static class PathGenerator
    {
        private const string DownloadedFilesFolderName = "AdminPanel\\DownloadedFiles\\";
        private const string UploadedFilesFolderName = "AdminPanel\\UploadedFiles\\";

        public static string AbsoluteRelativeCombine(string relative)
        {
            return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, relative));
        }

        public static string GeneratePathToDownloadedFilesFolder()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string oneDirectoryUp = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            string twoDirectoriesUp = oneDirectoryUp.Substring(0, oneDirectoryUp.LastIndexOf('\\') + 1);
            string fullPath = twoDirectoriesUp + DownloadedFilesFolderName;

            return fullPath;
        }

        public static string GeneratePathToUploadedFilesFolder()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string oneDirectoryUp = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            string twoDirectoriesUp = oneDirectoryUp.Substring(0, oneDirectoryUp.LastIndexOf('\\') + 1);
            string fullPath = twoDirectoriesUp + UploadedFilesFolderName;

            return fullPath;
        }
    }
}