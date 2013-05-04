using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculadora
{
    class Calculadora
    {
        private float total;

        /*
         *  Metodo construtor utilizado para inicializar o objeto.
         */

        public Calculadora()
        {
            total = 0;
        }

        public Calculadora(int a)
	    {
          total =  a;
	    }

        public float somar(float a, float b) //   Metodo Somar. 
        {
            return a + b;
        }

        public float somar(float a) //   Metodo Somar. 
        {
            return total = somar(total, a);
        }

        public float subtrair(float a, float b) // Metodo subtrair. 
        {
            return a - b;
        }

        public float subtrair(float a) // Metodo subtrair. 
        {
            return total = subtrair(total,a);
        }

        public float dividir(float a, float b)
        {
            return a / b;
        }

        public float dividir(float a)
        {
            return total = dividir(total, a);
        }
        public float multiplicar(float a, float b)
        {
            return a * b;
        }

        public float multiplicar(float a)
        {
            return total = multiplicar(total,a);
        }

        public float getTotal() 
        {
            return total;
        }

    }
}
