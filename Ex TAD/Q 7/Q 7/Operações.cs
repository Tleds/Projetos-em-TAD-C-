using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Q_7
{
    class Operações
    {
        Dados meusdados;
        public Operações()
        {
            meusdados = new Dados();
        }
        public void cadastrarprodutos()
        {
            Produtos meusprodutos;
            int opcao;
            do
            {
                Console.Clear();
                meusprodutos = new Produtos();
                meusprodutos.categoria = new Categorias();
                Console.WriteLine("Nome do Produto:");
                meusprodutos.nome = Console.ReadLine();
                Console.WriteLine("Codigo do Produto:");
                meusprodutos.categoria.codigo = Convert.ToInt16(Console.ReadLine());
                if (meusprodutos.categoria.codigo == 1)
                    meusprodutos.categoria.descricao = "Produto de Limpeza";
                if (meusprodutos.categoria.codigo == 2)
                    meusprodutos.categoria.descricao = "Padaria e Confeitaria";
                if (meusprodutos.categoria.codigo == 3)
                    meusprodutos.categoria.descricao = "Frios e Laticínios";
                if (meusprodutos.categoria.codigo == 4)
                    meusprodutos.categoria.descricao = "Bebidas";
                Console.WriteLine("Preço:");
                meusprodutos.preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Quantidade em estoque:");
                meusprodutos.qtdadeemestoque = Convert.ToInt32(Console.ReadLine());
                meusdados.inserir(meusprodutos);
                Console.WriteLine("Produto Cadastrado com Sucesso!!");
                Console.WriteLine("Cadastrar mais produtos?\n1-SIM\t2-NÃO");
                opcao = Convert.ToInt16(Console.ReadLine());

            } while (opcao != 2);
        }
        public void listarprodutos()
        {
            Console.Clear();
            ArrayList lista = meusdados.listar();
            foreach(Produtos x in lista)
            {
                Console.WriteLine("->{0} - {1} - {2} - {3} - {4}", x.nome, x.categoria.codigo, x.categoria.descricao, x.preco, x.qtdadeemestoque);
            }
            Console.ReadKey();
        }
    }
}
