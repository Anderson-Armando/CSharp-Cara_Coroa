using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cara_Coroa.Moedas
{
    public class Coins
    {
        private string lado;
        
        public string Lado  { get; set; }
        
        public string Jogar() {

            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";

            return Lado;
        }

        public string Jogar(string ladoSelecionado)
        {

            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";

            string Resultado = Lado == ladoSelecionado ? 
                $"Parabéns, {ladoSelecionado} e deu {Lado}" : 
                $"Perdeu, {ladoSelecionado} e deu {Lado}";

            return (Resultado);
        }


    }
}
