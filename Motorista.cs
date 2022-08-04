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
        // Método do tipo booleana para aceitar a corrida
        public bool AceitarCorrida()
        {
            // Limpa as mensagens do console
            Console.Clear();
            // Pergunta se o motorista quer aceitar a corrida
            Console.WriteLine("\r\nMotorista, aceita corrida? (s/n) ");

            // cria o tipo booleano e define como falso
            bool aceitaCorrida = false;
            // Estrutura de condição que define S para verdadeiro(aceita corrida) e N para falso(não aceita corrida)
            switch (Console.ReadLine())
            {
                case "s":
                    aceitaCorrida = true;
                    break;
                case "n":
                    aceitaCorrida = false;
                    break;
            }
            // Se aceita corrida for verdadeiro aparece a mensagem:
            if (aceitaCorrida)
            {
                Console.WriteLine("\r\nCorrida aceita! ");
                Thread.Sleep(2000);
                return true;
            }
            // Se aceita corrida for falso aparece a mensagem:
            Console.WriteLine("\r\nCorrida negada! ");
            // Para a execução em um período de tempo especificado
            Thread.Sleep(2000);
            return false;
        }

        // Método para finalizar a corrida
        public void FinalizarCorrida()
        {
            Console.WriteLine("\r\nCorrida finalizada!");
        }

    }
}
