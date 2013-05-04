using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tacarmusica
{
    class Program
    {
        static void Main(string[] args)
        {
            sintetizador sin = new sintetizador();
            sin.TocarMusica(3);
            sin.AlterarVelocidade(2);
        }        
    }
    class sintetizador
    {
        private int velocidade;
        private int rept;

        public sintetizador(int velocidade)
        {
            velocidade = 1000;
        }
    
        public int TocarMusica(int Musica)
        {
            switch (Musica)
            {
                case '1':  
                       Console.Beep(256, 500); // Dó
                       Console.Beep(288, 500); // Ré
                       Console.Beep(320, 500); // Mi
                       Console.Beep(341, 500); // Fá
                       Console.Beep(384, 500); // Sol
                       Console.Beep(427, 500); // Lá
                       Console.Beep(480, 500); // Si
                   break;
            }
            return Musica;
        }

        public int AlterarVelocidade(int velocidade)
        {

            return velocidade;
        }

    }
}
