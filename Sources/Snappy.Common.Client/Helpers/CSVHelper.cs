using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Snappy.Common.Client.Helpers
{
    public class CSVHelper
    {
        public string Separator { get; set; }

        public CSVHelper(string separator = ",")
        {
            Separator = separator;
        }

        public List<string> GetLines(IFormFile formFile)
        {
            var lines = new List<string>();
            using (var streamReader = new StreamReader(formFile.OpenReadStream(), Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}