using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUber
{
    // Passageiro recebe como herança as propriedades de usuário
    public class Passageiro : Usuario
    {
        public string Origem { get; set; }
        public string Destino { get; set; }

        public void InformarEnderecoOrigem()
        {
            Console.WriteLine("O endereço de origem é: R. Vista Alegre, 129 - Vila LourdesCarapicuíba - SP, 06397-250");
        }

        public void InformarEnderecoDestino()
        {
            Console.WriteLine("O endereço de destino é: Av. Piracema, 669 - Tamboré, Barueri - SP, 06460-030");
        }
        public void BuscarCorrida()
        {
            Console.Clear();
            Console.WriteLine("Buscando corrida...");
        }

        public string PagarCorrida()
        {
            return "Corrida paga com sucesso!";
        }

        public void CancelarCorrida()
        {
            Console.WriteLine("Corrida cancelada com sucesso!");
        }
    }
}
