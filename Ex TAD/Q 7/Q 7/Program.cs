using System;

namespace Q_7
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
                Console.WriteLine("1-Cadastrar Produtos");
                Console.WriteLine("2-Listar Produtos");
                Console.WriteLine("3-Inventário do Estoque");
                Console.WriteLine("Opção: \t\t\t Pressione ESC para sair");
                opcao = Convert.ToInt16(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        minhasoperacoes.cadastrarprodutos();
                        break;
                    case 2:
                        minhasoperacoes.listarprodutos();
                        break;
                    case 3:
                       // minhasoperacoes.inventario();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
