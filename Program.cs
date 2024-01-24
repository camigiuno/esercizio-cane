using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane cane = new Cane (Razza, Nome, Proprietario);
            cane.Proprietario.Nome = "simone";
            cane.Razza = "Labrador";
            cane.Nome = "Ringhio";
        }
    }
}
