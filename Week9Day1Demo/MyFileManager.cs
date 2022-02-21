using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace Week9Day1Demo
{
    public class MyFileManager
    {
        private readonly string _filePath;

        public MyFileManager(string filePath)
        {
            _filePath = filePath;
        }

        // Synchronous Version of method
        public int CountCharacters()
        {
            using (var reader = new StreamReader(_filePath))
            {
                var content = reader.ReadToEnd();
                var count = content.Length;

                return count;
            }
        }

        // Asynchronous Version of method
        public async Task<int> CountCharactersAsync()
        {
            using (var reader = new StreamReader(_filePath))
            {
                var content = await reader.ReadToEndAsync();
                var count = content.Length;

                return count;
            }
        }

        // Synchronous Version of method
        public string GetAllText()
        {
            using (var reader = new StreamReader(_filePath))
            {
                var content = reader.ReadToEnd();
                return content;
            }
        }

        // Asynchronous Version of method
        public async Task<string> GetAllTextAsync()
        {
            using (var reader = new StreamReader(_filePath))
            {
                var content = await reader.ReadToEndAsync();
                return content;
            }
        }

        // Single Responsibility Principle
        #region Synchronous SortingCode
        public void Sort()
        {
            var lineArray = GetLinesFromFile();

            Array.Sort(lineArray, StringComparer.InvariantCulture);

            CreateFileFromArray(lineArray);
        }

        private void CreateFileFromArray(string[] lineArray)
        {
            var fileInfo = new FileInfo(_filePath);
            var tempFilePath = Path.Combine(fileInfo.DirectoryName, "temp.txt");

            File.WriteAllLines(tempFilePath, lineArray);

            File.Delete(_filePath);
            File.Move(tempFilePath, _filePath);
        }

        private string[] GetLinesFromFile()
        {
            var lines = new StringCollection();

            using (var reader = new StreamReader(_filePath))
            {
                do
                {
                    var fileLine = reader.ReadLine();
                    lines.Add(fileLine);
                } while (!reader.EndOfStream);
            }

            var lineArray = new string[lines.Count];
            lines.CopyTo(lineArray, 0);

            return lineArray;
        }
        #endregion

        #region Asynchronous SortingCode
        public async Task SortAsync()
        {
            var lineArray = await GetLinesFromFileAsync();

            Array.Sort(lineArray, StringComparer.InvariantCulture);

            CreateFileFromArray(lineArray);
        }

        private async Task<string[]> GetLinesFromFileAsync()
        {
            var lines = new StringCollection();

            using (var reader = new StreamReader(_filePath))
            {
                do
                {
                    var fileLine = await reader.ReadLineAsync();
                    lines.Add(fileLine);
                } while (!reader.EndOfStream);
            }

            var lineArray = new string[lines.Count];
            lines.CopyTo(lineArray, 0);

            return lineArray;
        }
        #endregion
    }
}