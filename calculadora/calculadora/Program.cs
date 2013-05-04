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
            Calculadora calc = new Calculadora(); //Instaciou o objeto do tipo Calculadora.

            calc.somar(5, 6);  //Utilizndo o metodo somar que pertence ao Objeto calc.   
            Console.WriteLine(calc.multiplicar (50, 5));
            
            

            Console.Read();
        }
    }
}

