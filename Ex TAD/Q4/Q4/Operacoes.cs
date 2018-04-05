using System;
using System.Collections.Generic;
using System.Text;

namespace Q4
{
    class Filmes
    {
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Diretor;

        public string Diretor
        {
            get { return _Diretor; }
            set { _Diretor = value; }
        }

        private string _Duraçao;

        public string Duraçao
        {
            get { return _Duraçao; }
            set { _Duraçao = value; }
        }
        private string _Categoria;

        public string Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        private string _AnoEstreia;

        public string AnoEstreia
        {
            get { return _AnoEstreia; }
            set { _AnoEstreia = value; }
        }

        public Filmes()
        {
            _Nome = " ";
            _Diretor = " ";
            _Categoria = " ";
            _AnoEstreia = " ";
        }
    }
    class Operacoes
    {
        Dados meusdados = new Dados();
        public void cadastrarfilmes()
        {
            Filmes meusfilmes;
            int opcao;
            do
            {
                meusfilmes = new Filmes();
                Console.Clear();
                Console.WriteLine("Nome do filme....: ");
                meusfilmes.Nome = Console.ReadLine();
                Console.WriteLine("Diretor..........: ");
                meusfilmes.Diretor = Console.ReadLine();
                Console.WriteLine("Categoria........: ");
                meusfilmes.Categoria = Console.ReadLine();
                Console.WriteLine("Ano de Estréia...: ");
                meusfilmes.AnoEstreia = Console.ReadLine();;
                Console.WriteLine("Duração..........: ");
                meusfilmes.Duraçao = Console.ReadLine(); ;
                meusdados.inserir(meusfilmes);
                Console.WriteLine("Deseja cadastrar mais Filmes?\n 1-Sim\t\t2-Não");
                opcao = Convert.ToInt16(Console.ReadLine());
            } while (opcao != 2);
        }
        public void listarfilmes()
        {
            meusdados.listar();
        }
        public void Pesquisar()
        {
            string categoria;
            Console.WriteLine("Digite a categoria desejada: ");
            categoria = Console.ReadLine();
            meusdados.pesquisar(categoria);

        }
    }
}
