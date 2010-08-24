using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace MoleSample
{
    public class Foo
    {
        public string ConfigDirectory;

        public Stream GetTextFile(string name)
        {
            return File.Open(ConfigDirectory + name + ".txt", FileMode.Open);
        }
    }
}
