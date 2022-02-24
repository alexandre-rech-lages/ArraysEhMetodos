using System;

namespace ArraysEhMetodos.ConsoleApp
{
    //escopo de variáveis
    //-> local
    //-> global

    //tipo de armazenamento de valores na memória

    public class ExemploModificadorParametro
    {
        static void Main2(string[] args)
        {
            int number;

            bool success = int.TryParse("1", out number);

            int idade; //variável local

            DefinirIdade(out idade); 

            FazerAniversario(ref idade);

            MostrarIdade(idade);
        }

        static void DefinirIdade(out int id1)
        {
            id1 = 37;
        }

        static void FazerAniversario(ref int id2)
        {
            id2++;
        }

        static void MostrarIdade(int idd)
        {
            Console.WriteLine(idd);
        }

    }
}
