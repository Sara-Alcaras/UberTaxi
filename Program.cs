namespace DesafioUber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializa a classe passageiro
            Passageiro passageiro = new();

            // Inicializa a classe motorista
            Motorista motorista = new();

            Console.WriteLine("Nome e telefone do passageiro:");
            passageiro.Name = "\r\nSara";
            Console.WriteLine(passageiro.Name);

            passageiro.Telefone = "40028922";
            Console.WriteLine(passageiro.Telefone);

            passageiro.InformarEnderecoOrigem();

            passageiro.InformarEnderecoDestino();

            // Mostra o valor da corrida que já está pré definido dentro da classe corrida
            Console.WriteLine($"\r\nValor da corrida: {Corrida.Valor}");
            // Para a execução em um período de tempo especificado
            Thread.Sleep(3000);

            passageiro.SelecionarTipoPagamento();

            bool aceitaCorrida = false;
            // Estrutura de repetição se aceita corrida for false, busca uma nova corrida
            while (!aceitaCorrida)
            {
                passageiro.BuscarCorrida();

                aceitaCorrida = motorista.AceitarCorrida();
                // Se aceita corrida for verdadeiro, aparece os dados do motorista e do veiculo
                if (aceitaCorrida)
                {
                    Console.WriteLine("\r\nNome do motorista:");
                    motorista.Name = "Samuel";
                    Console.WriteLine(motorista.Name);

                    Console.WriteLine("\r\nDados do veiculo:");
                    Veiculo.MostrarDadosVeiculo();
                }
            }

            passageiro.PagarCorrida();
            Thread.Sleep(2000);

            motorista.FinalizarCorrida();


        }
    }

}
