using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jokenpo.Models;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Jokenpo.ViewModel
{
    public partial class PlayerViewModel: ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagemp1;

        [ObservableProperty]
        private string imagemp2;

        [ObservableProperty]
        private string pontuacaop1;

        [ObservableProperty]
        private string pontuacaop2;

        [ObservableProperty]
        private string opplayer1;

        public ICommand JogarCommand { get; }

        public PlayerViewModel()
        {
            JogarCommand = new Command(Jogar);
            Pontuacaop1 = cont1.ToString();
            Pontuacaop2 = cont2.ToString();
        }

        int cont1 = 0;
        int cont2 = 0;

        public void Jogar()
        {
            //cria uma moeda
            Player player = new Player();

            //chama o método jogar da moeda
            player.Jogar();
            Imagemp1 = $"{Opplayer1}.png";
            Imagemp2 = $"{player.OpPlayer2}.png";

            if (Opplayer1 == player.OpPlayer2)
            {
                Pontuacaop1 = Pontuacaop1;
                Pontuacaop2 = Pontuacaop2;
            }
            else if (Opplayer1 == "pedra" && player.OpPlayer2 == "tesoura")
            {
                Pontuacaop1 = (cont1=cont1+1).ToString();
                if (Pontuacaop1 == "10")
                {
                    Resultado = "\nVocê ganhou\n";
                }
            }else if (Opplayer1 == "papel" && player.OpPlayer2 == "pedra") {
                Pontuacaop1 = (cont1 = cont1 + 1).ToString();
                if (Pontuacaop1 == "10")
                {
                    Resultado = "\nVocê ganhou\n";
                }
            }
            else if (Opplayer1 == "tesoura" && player.OpPlayer2 == "papel")
            {
                Pontuacaop1 = (cont1 = cont1 + 1).ToString();
                if (Pontuacaop1 == "10")
                {
                    Resultado = "\nVocê ganhou\n";
                }
            }
            else
            {
                Pontuacaop2 = (cont2 = cont2 + 1).ToString();
                if (Pontuacaop2 == "10")
                {
                    Resultado = "\nVocê perdeu\n";
                }
            }


        }
    }
}