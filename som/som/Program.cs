using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace som
{
    class Program
    {
        static void Main(string[] args)
        {
            Som(3); // Execulta musica
        }

        static public void Som(int repet) //metodo som
        { 
            

            for (int i = 0; i < repet; i++)
            {
               Console.Beep(256, 500); // Dó
               Console.Beep(288, 500); // Ré
               Console.Beep(320, 500); // Mi
               Console.Beep(341, 500); // Fá
               Console.Beep(384, 500); // Sol
               Console.Beep(427, 500); // Lá
               Console.Beep(480, 500); // Si
            }
            
        }

    }
}
