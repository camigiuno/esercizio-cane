using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Cane
    {
        public string Razza { get; set; }
        public string Nome { get; set; }
        public Persona Proprietario { get; set; }
        public Cane (string Razza, string Nome)
        {
            this.Razza = Razza;
            this.Nome = Nome;
            this .Proprietario = new Persona ();
        }
    }
}
