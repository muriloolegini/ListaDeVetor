using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor v = new Vetor();

            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string e = "E";
            string f = "F";
            string g = "G";
            string h = "H";
            string i = "I";

            v.Adicionar(a);
            v.Adicionar(b);
            v.Adicionar(c);
            v.Adicionar(d);
            v.Adicionar(e);
            v.Adicionar(f);
            v.Adicionar(g, 10);
            v.Adicionar(h, 2);
            v.Adicionar(i, 2);

            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}