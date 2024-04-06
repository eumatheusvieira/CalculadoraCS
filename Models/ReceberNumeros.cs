using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class ReceberNumeros
    {

        public int PrimeiroNumero()
        {
            Console.Clear();
            Console.WriteLine("DIGITE O PRIMEIRO NÚMERO: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        public int SegundoNumero()
        {
            Console.WriteLine("DIGITE O SEGUNDO NÚMERO: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
    }
}