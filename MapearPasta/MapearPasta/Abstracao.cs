using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapearPasta
{
    public class Abstracao
    {
        public class Pasta
        {
            public string Titulo { get; set; }

            public string Caminho { get; set; }

            public List<Pasta> Pastas { get; set; }

            public List<Arquivo> Arquivos { get; set; }

            public Pasta PastaPai { get; set; }
        }

        public class Arquivo
        {
            public string Titulo { get; set; }

            public string Caminho { get; set; }
        }
    }
}
