using System;

namespace Q4
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
                Console.WriteLine("Cadastro de Filmes.");
                Console.WriteLine("___________________");
                Console.WriteLine("Selecione a opção desejada: \n 1-Cadastrar Filmes \n 2-Listar Filmes.\n 3-Pesquisar por Categoria \nAperte a tecla ESC para sair...");
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
                if(opcao == 3)
                {
                    minhasoperacoes.Pesquisar();
                }
                if (opcao != 1 && opcao != 2)
                {
                    if (opcao != 3)
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
