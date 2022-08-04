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
        
        // Utiliza o Enum
        public TipoPagamento TipoPagamento { get; set; }

        // Método que recebe o endereço de origem do passageiro
        public void InformarEnderecoOrigem()
        {
            Console.WriteLine("\r\nInforme endereço de origem: ");
            Origem = Console.ReadLine();
        }

        // Método que recebe o endereço de destino do passageiro
        public void InformarEnderecoDestino()
        {
            Console.WriteLine("\r\nInforme endereço de destino: ");
            Destino = Console.ReadLine();
        }

        // Método que busca a corrida
        public void BuscarCorrida()
        {
            // Limpa as mensagens do console
            Console.Clear();

            Console.Write("\r\nBuscando corrida");

            // Para a execução em um período de tempo especificado
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);

            //Informa que a corrida foi localizada
            Console.WriteLine("\r\nCorrida localizada!");
            Thread.Sleep(2000);
        }

        // Método para selecionar a forma de pagamento
        public void SelecionarTipoPagamento()
        {
            // Se o tipo de pagamento for igual ao enum não existe
            while (TipoPagamento == TipoPagamento.NaoExiste)
            {
                // Mostra a mensagem para selecionar o tipo de pagamento
                Console.WriteLine("\r\n\r\nInforme um tipo de pagamento: ");
                Console.WriteLine("1 - Dinheiro");
                Console.WriteLine("2 - Crédito");
                Console.WriteLine("3 - Débito");

                // Converte o enum tipo pagamento para inteiro
                int.TryParse(Console.ReadLine(), out int tipoPagamento);

                // Define o número de entrada para o tipo de pagamento
                switch (tipoPagamento)
                {
                    case 1:
                        TipoPagamento = TipoPagamento.Dinheiro;
                        break;
                    case 2:
                        TipoPagamento = TipoPagamento.Credito;
                        break;
                    case 3:
                        TipoPagamento = TipoPagamento.Debito;
                        break;
                    default:
                        TipoPagamento = TipoPagamento.NaoExiste;
                        Console.WriteLine("\r\nTipo de pagamento inválido!");
                        break;
                }
            }
            // Informa o tipo de pagamento escolhido
            Console.WriteLine($"\r\nTipo do pagamento: {TipoPagamento}");
            // Para a execução em um período de tempo especificado
            Thread.Sleep(3000);
            // Limpa as mensagens do console
            Console.Clear();
        }

        // Método para pagar a corrida
        public void PagarCorrida()
        {
            Console.WriteLine("\r\nPagamento realizado.");
        }

        // Método para cancelar a corrida
        public void CancelarCorrida()
        {
            Console.WriteLine("\r\nCorrida cancelada com sucesso!");
        }
    }
}
