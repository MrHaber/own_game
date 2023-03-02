using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SvoyaIgra
{
    public class FileReader
    {

        private string name;

        public FileReader(string name)
        {
            this.name = name;
        }

        public string read()
        {
            return File.ReadAllText(name);
        }

        public bool isExists()
        {
            return File.Exists(name);
        }

        public string Name
        {
            get { return name; }
        }

    }
}
