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

            passageiro.SelecionarTipoPagamento();


        }
    }

}
