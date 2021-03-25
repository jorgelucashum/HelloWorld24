using System;

namespace HelloWorld24
{
    class Program
    {
        // DateTime:
        // - Representa um instante
        // É do tipo valor (struct)

        static void Main(string[] args)
        {
            // Um objeto DateTime internamente armazena: O númerode "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum.

            DateTime d = DateTime.Now; // '.Now' retorna a data atual do sistema.
            DateTime d0 = DateTime.Today; // '.Today' retorna somente a data sem a hora.
            DateTime d1 = DateTime.UtcNow; // '.UtcNow' retornao horário GMT, universal.

            DateTime d2 = new DateTime(2021, 03, 25); // Construtor do 'DateTime' usando somente a sobrecarga do ano, mes e dia
            DateTime d3 = new DateTime(2021, 03, 25, 20, 45, 3); // Construtor do 'DateTime' usando a sobrecarga do ano, mes e dia e hora, minutos, segundos.
            DateTime d4 = new DateTime(2021, 03, 25, 20, 45, 3, 500); // Construtor do 'DateTime' usando a sobrecarga do ano, mes e dia e hora, minutos, segundos, milissegundo.


            Console.WriteLine(d);
            Console.WriteLine(d.Ticks); // mostra todos os ticks desde 1 de janeira da era comum.
            Console.WriteLine(d0);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

        }
    }
}
