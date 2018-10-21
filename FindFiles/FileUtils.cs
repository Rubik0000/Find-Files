using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.ComponentModel;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;
using System.IO;

namespace FindFiles
{
    /// <summary>
    /// Provides function to work with files and directories
    /// </summary>
    static class FileUtils
    {
        // Import form "kernel32.dll"

        private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern IntPtr FindFirstFile(string lpFileName, out WIN32_FIND_DATA lpFindFileData);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern bool FindNextFile(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern bool FindClose(IntPtr hFindFile);

        private static string MakePath(string path) => Path.Combine(path, "*");

        /// <summary>
        /// Gets an internal data of a catalog
        /// </summary>
        /// <param name="path">The path to catalog</param>
        /// <param name="isDirs">If true then list of directories
        /// else - files</param>
        /// <param name="fullPath">Whether gets the internal data 
        /// with a parant path</param>
        /// <returns>The names of files or directories</returns>
        private static IEnumerable<string> GetInternals(
            string path, 
            bool isDirs,
            bool fullPath)
        {            
            WIN32_FIND_DATA findData;
            var findHandle = FindFirstFile(MakePath(path), out findData);
            if (findHandle == INVALID_HANDLE_VALUE)
                throw new Win32Exception(Marshal.GetLastWin32Error(), "OMG");
            
            var internals = new LinkedList<string>();
            try
            {                
                while (FindNextFile(findHandle, out findData))
                {
                    if (findData.cFileName == ".." || findData.cFileName == ".")
                        continue;

                    string fname = fullPath ? 
                        Path.Combine(path, findData.cFileName) :
                        findData.cFileName;

                    if (isDirs)
                    {
                        if (findData.dwFileAttributes == FileAttributes.Directory)
                            internals.AddLast(fname);
                    }
                    else
                    {
                        if (findData.dwFileAttributes != FileAttributes.Directory)
                            internals.AddLast(fname);
                    }       
                }
            }
            finally
            {
                FindClose(findHandle);
            }
            return internals;
        }

        /// <summary>
        /// Gets a list of files from a given directory
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetFiles(string path, bool fullPath) =>
            GetInternals(path, false, fullPath);

        /// <summary>
        /// Gets a list of directories from a given catalog
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetDirectories(string path, bool fullPath) =>
            GetInternals(path, true, fullPath);

        /// <summary>
        /// Gets a list of directories from a given catalog recursivly
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetAllDirectories(string path)
        {
            var dirs = new LinkedList<string>();
            foreach (var dir in GetDirectories(path, true))
            {
                string relPath = Path.Combine(path, dir);
                //string relPath = path;
                dirs.AddLast(relPath);
                dirs = new LinkedList<string>(
                    dirs.Concat(GetAllDirectories(relPath)));                
            }
            return dirs;
        }

        /// <summary>
        /// Gets full of the directory or file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFullPath(string path) => 
            Path.GetFullPath(path);        
    }
}
