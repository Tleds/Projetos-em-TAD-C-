using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Q_1_POO
{
   
    struct alunos
    {
        public string nome { get; set; }
        public string mail { get; set; }
        public int dianascimento { get; set; }
        public string mesnascimento { get; set; }
        public int anonascimento { get; set; }
        public string telefone { get; set; }

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
                Console.WriteLine("Nome do aluno....: ");
                meusalunos.nome = Console.ReadLine();
                Console.WriteLine("Mail.............: ");
                meusalunos.mail = Console.ReadLine();
                Console.WriteLine("Telefone.........: ");
                meusalunos.telefone = Console.ReadLine();
                Console.WriteLine("Dia do nascimento: ");
                meusalunos.dianascimento = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Mês..............: ");
                meusalunos.mesnascimento = Console.ReadLine();
                Console.WriteLine("Ano..............: ");
                meusalunos.anonascimento = Convert.ToInt16(Console.ReadLine());
                meusdados.inserir(meusalunos);
                Console.WriteLine("Deseja cadastrar mais alunos?\n 1-Sim\t\t2-Não");
                opcao = Convert.ToInt16(Console.ReadLine());
            } while (opcao != 2);
        }
        public void listaralunos()
        {
            Console.Clear();
            ArrayList lista = new ArrayList();
            lista = meusdados.listaralunos();
            foreach(alunos x in lista)
            {
                Console.WriteLine("Nome: {0}\nTelefone: {1}\nMail: {2}\nData de nascimento: {3} de {4} de {5}\n\n", x.nome, x.telefone, x.mail, x.dianascimento, x.mesnascimento, x.anonascimento );
            }
            Console.ReadKey();
        }
    }
}
