using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    internal class Player
    {
        public string OpPlayer2 { get; set; }

        public Player() { 
        
        
        }

        public void Jogar()
        {
            if (new Random().Next(3) == 0)
            {
                OpPlayer2 = "pedra";
            }else if(new Random().Next(3) == 1)
            {
                OpPlayer2 = "papel";
            }
            else
            {
                OpPlayer2 = "tesoura";
            }
        }
    }
}
