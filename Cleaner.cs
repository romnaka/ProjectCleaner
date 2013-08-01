using System.IO;

namespace ProjectCleaner
{
    internal class Cleaner
    {
        private const long MaxFileSize = 20971520;

        //Method to clean project
        public static void Clean(string folder)
        {
            string[] dirs = Directory.GetDirectories(folder, "*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

            foreach (string nestedFolder in dirs)
            {
                string folderName = nestedFolder.ToLower().Substring(nestedFolder.LastIndexOf("\\", System.StringComparison.Ordinal) + 1); 
                if (folderName == "drop" || 
                    folderName == "bin" || 
                    folderName== "obj")
                if (nestedFolder.ToLower().Substring(nestedFolder.LastIndexOf("\\", System.StringComparison.Ordinal) + 1) == "drop" || 
                    nestedFolder.ToLower().Substring(nestedFolder.LastIndexOf("\\", System.StringComparison.Ordinal) + 1) == "bin" || 
                    nestedFolder.ToLower().Substring(nestedFolder.LastIndexOf("\\", System.StringComparison.Ordinal) + 1) == "obj")
                {
                    Directory.Delete(nestedFolder, true);
                }
            }
     
            foreach (var file in files)
            {
                string ext = Path.GetExtension(file);
                long size = new FileInfo(file).Length;
                if (ext.Equals(".suo") || ext.Equals(".user") || ext.Equals(".pdb") || size > MaxFileSize)
                    File.Delete(file);
            }
           
        }
    }
}
