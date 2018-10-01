using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapearPasta
{
    class Program
    {
        static void Main(string[] args)
        {            
            var dir = new System.IO.DirectoryInfo(@"C:\Users\ISRAEL\Desktop\startbootstrap-sb-admin-gh-pages");

            var pastas = dir.GetDirectories();

            var arquivos = dir.GetFiles();         

            

           
        }
    }
}
