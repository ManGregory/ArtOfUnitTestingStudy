using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalyzer
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("file name should be set");
            }
            return fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
