using System;
using System.Collections.Generic;
using System.Text;

namespace Q_3
{
    public class Date
    {
        public int dia { get; set; }
        public string mes { get; set; }
        public int ano { get; set; }
        public Date()
        {
            dia = 0;
            mes = " ";
            ano = 0;
        }
    }
    public class alunos
    {
        public string nome { get; set; }
        public string mail { get; set; }
        public string telefone { get; set; }
        public Date nascimento { get; set; }
        public alunos()
        {
            nome = " ";
            mail = " ";
            telefone = " ";
        }

    }
    class Operações
    {
        Dados meusdados;
        public Operações()// construtor
        {
            meusdados = new Dados();
        }
        public void cadastraralunos()
        {
            
            alunos meusalunos;
            int opcao;
            do
            {
                Console.Clear();
                meusalunos = new alunos();
                meusalunos.nascimento = new Date();
                Console.WriteLine("Nome do aluno....: ");
                meusalunos.nome = Console.ReadLine();
                Console.WriteLine("Mail.............: ");
                meusalunos.mail = Console.ReadLine();
                Console.WriteLine("Telefone.........: ");
                meusalunos.telefone = Console.ReadLine();
                Console.WriteLine("Dia do nascimento: ");
                meusalunos.nascimento.dia = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Mês..............: ");
                meusalunos.nascimento.mes = Console.ReadLine();
                Console.WriteLine("Ano..............: ");
                meusalunos.nascimento.ano = Convert.ToInt16(Console.ReadLine());
                meusdados.inserir(meusalunos);
                Console.WriteLine("Deseja cadastrar mais alunos?\n 1-Sim\t\t2-Não");
                opcao = Convert.ToInt16(Console.ReadLine());
            } while (opcao != 2);
        }
        public void listaralunos()
        {
            Console.Clear();
            meusdados.listaralunos();
        }
    }
}
