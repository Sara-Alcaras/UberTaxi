namespace DesafioUber
{
    class Program 
    {
        static void Main(string[] args)
        {
            Passageiro passageiro = new Passageiro();

            passageiro.Name = "o nome do passageiro é Sara";
            Console.WriteLine(passageiro.Name);

            passageiro.Telefone = "o telefone do passageiro é 40028922";
            Console.WriteLine(passageiro.Telefone);

            Console.WriteLine(passageiro.PagarCorrida());
        }
    }

}
