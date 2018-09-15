using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Dogs
{
    public static class FilesOperations
    {
        public static void SaveFileToDesktop(string json, string fileName)
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText(fileLocation + $"\\{fileName}.json", json);
        }

        public static string ReadFileFromDesktop(string fileName)
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return File.ReadAllText(fileLocation + $"\\{fileName}");
        }

        public static void SaveFile(string json, string fileName, string fileLocation = "")
        {
            if (string.IsNullOrWhiteSpace(fileLocation))
            {
                fileLocation = Directory.GetCurrentDirectory();
            }
            File.WriteAllText(fileLocation + $"\\{fileName}.json", json);
        }

        public static string ReadFile(string fileName, string fileLocation = "")
        {
            if (string.IsNullOrWhiteSpace(fileLocation))
            {
                fileLocation = Directory.GetCurrentDirectory();
            }
            return File.ReadAllText(fileLocation + $"\\{fileName}");
        }
    }
}
