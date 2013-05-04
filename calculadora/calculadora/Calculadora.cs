using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculadora
{
    class Calculadora
    {

        /*
         *  Metodo construto utilizado para inicializar o objeto.
         */
        public Calculadora()
	    {
            Console.WriteLine("Objeto inicializado.");            
	    }

        public float somar(float a, float b) //   Metodo Somar. 
        {
            return a + b;
        }

        public float subtrair(float a, float b)  
        {
            return a - b;
        }

        public float dividir(float a, float b)
        {
            return a / b;
        }

        public float multiplicar(float a, float b)
        {
            return a * b;
        }

    }
}
