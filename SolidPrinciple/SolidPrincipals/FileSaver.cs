using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace SRP_Principle
{
    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string fileName, WorkReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}

