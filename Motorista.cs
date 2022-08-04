using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUber
{
    // Motorista recebe como herança as propriedades de usuário
    public class Motorista : Usuario
    {
        public Veiculo Veiculo { get; set; }
        public bool AceitarCorrida(bool aceita)
        {
            return aceita;
        }

        public void FinalizarCorrida()
        {
            Console.WriteLine("Corrida finalizada com sucesso!");
        }


    }
}
