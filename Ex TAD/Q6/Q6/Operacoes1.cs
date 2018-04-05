using System;
using System.Collections.Generic;
using System.Text;

namespace Q6
{
    class Endereco
    {
        public string rua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }
        public Endereco()
        {
            rua = " ";
            bairro = " ";
            cidade = " ";
            complemento = " ";
        }
    }
    class Data
    {
        public string dia { get; set; }
        public string mes { get; set; }
        public string ano { get; set; }
        public Data()
        {
            dia = " ";
            mes = " ";
            ano = " ";
        }
    }
    class Funcionarios
    {
        public string Nome { get; set; }
        public Endereco Endereço { get; set; }//
        public string Telefone { get; set; }
        public Data Admissao { get; set; }//
        public Data Nascimento { get; set; }//
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string identidade { get; set; }
        public string cpf { get; set; }
        public string carteiradetrab { get; set; }


        public Funcionarios()
        {
            Nome = " ";
            Telefone = " ";
            NomePai = " ";
            NomeMae = " ";
            identidade = " ";
            cpf = " ";
            carteiradetrab = " ";

        }
    }
    class Academico:Funcionarios
    {
        public string Horas { get; set; }
        public string Aulas { get; set; }
        public string titulacao { get; set; }
        public Academico()
        {
            Horas = " ";
            Aulas = " ";
            titulacao = " ";
        }
    }
    class Administraçao:Funcionarios
    {
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public Administraçao()
        {
            Cargo = " ";
            Setor = " ";
        }
    }
    class Operacoes
    {
        Dados meusdados = new Dados();
        public void cadastrarfilmes()
        {
            Funcionarios meusfilmes;
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
                meusfilmes.AnoEstreia = Console.ReadLine(); ;
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
    }
}
