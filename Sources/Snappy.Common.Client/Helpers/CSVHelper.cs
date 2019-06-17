using System.Collections.Generic;
using System.IO;

using Microsoft.AspNetCore.Http;

namespace Snappy.Common.Client.Helpers
{
    public class CSVHelper
    {
        public string Seperator { get; set; }

        public CSVHelper(string seperator = ",")
        {
            Seperator = seperator;
        }

        public List<string> GetLines(IFormFile formFile)
        {
            var lines = new List<string>();
            using (var streamReader = new StreamReader(formFile.OpenReadStream()))
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