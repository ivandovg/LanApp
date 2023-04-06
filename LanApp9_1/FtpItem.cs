using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanApp9_1
{
    internal class FtpItem
    {
        public string ExternalPath { get; set; }
        public string ShortPath { get; set; }
        public bool IsDirectory { get; set; }
        public FtpItem(string path) 
        {
            ExternalPath = path;
            IsDirectory = path.StartsWith("d");

            //ShortPath = path.Split(new char [' '], StringSplitOptions.RemoveEmptyEntries).Last();
            //if (string.IsNullOrEmpty(ShortPath))
            ShortPath = path.Substring(path.LastIndexOf(" ") + 1);
        }
        public override string ToString()
        {
            return ShortPath;
        }
    }
}
