using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes minhasoperacoes = new Operacoes();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Funcionários.");
                Console.WriteLine("________________________");
                Console.WriteLine("Selecione a opção desejada: \n 1-Cadastrar Funcionários \n 2-Listar Funcionários.\nAperte a tecla ESC para sair...");
                opcao = Convert.ToInt16(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.Clear();
                    minhasoperacoes.cadastrarfilmes();
                }
                if (opcao == 2)
                {
                    Console.Clear();
                    minhasoperacoes.listarfilmes();
                }
                if (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Opção inválida!");
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
