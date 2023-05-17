using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    public class FileLogger
    {
        private string logPath { get; set; }
        public FileLogger() { }
        public void Log(string message) {
            System.IO.File.WriteAllText(@"D:\\errors.txt", message);
        }
    }
}
