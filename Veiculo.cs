using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUber
{
    public static class Veiculo
    {
        // Propriedades estaticas do tipo string que tem um valor definido
        public static string Cor { get { return "Vermelho"; } }
        public static string Placa { get { return "FLF55E0"; } }
        public static string Modelo { get { return "New Fiesta"; } }

        // Método para mostrar dados do veiculo
        public static void MostrarDadosVeiculo()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Placa: {Placa}");
        }
    }
}