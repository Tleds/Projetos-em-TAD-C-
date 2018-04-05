using System;

namespace Q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operações minhasoperacoes = new Operações();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos.");
                Console.WriteLine("___________________");
                Console.WriteLine("Selecione a opção desejada: \n 1-Cadastro de alunos.\n 2-Listar alunos.\nAperte a tecla ESC para sair...");
                opcao = Convert.ToInt16(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.Clear();
                    minhasoperacoes.cadastraralunos();
                }
                if (opcao == 2)
                {
                    Console.Clear();
                    minhasoperacoes.listaralunos();
                }
                if (opcao != 1 && opcao != 2)
                    Console.WriteLine("Opção inválida!");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
