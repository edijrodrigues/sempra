using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora(100); //Instaciou o objeto do tipo Calculadora.
            
            calc.somar(6);
            calc.subtrair(2);
            calc.dividir(2);

            //Console.WriteLine(calc.getTotal());
            
               
            Console.Read();
        }
    }
}

