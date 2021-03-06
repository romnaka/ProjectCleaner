﻿using System.IO;

namespace ProjectCleaner
{
    internal static class Cleaner
    {
        private const long MaxFileSize = 20971520;

        //Method to clean project
        public static void Clean(string folder)
        {
            string[] dirs = Directory.GetDirectories(folder, "*", SearchOption.AllDirectories);
            foreach (string nestedFolder in dirs)
            {
                string folderName = nestedFolder.ToLower().Substring(nestedFolder.LastIndexOf("\\", System.StringComparison.Ordinal) + 1); 
                if (folderName == "drop" || 
                    folderName == "bin" || 
                    folderName== "obj")
                {
                    Directory.Delete(nestedFolder, true);
                }
            } 
            
            string[] files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                string ext = Path.GetExtension(file);
                long size = new FileInfo(file).Length;
                if (ext != null && (ext.Equals(".suo") || ext.Equals(".user") || ext.Equals(".pdb") || size > MaxFileSize))
                    File.Delete(file);
            }
           
        }
    }
}
