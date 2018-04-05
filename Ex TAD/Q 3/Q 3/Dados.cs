using System;
using System.Collections.Generic;
using System.Text;

namespace Q_3
{
    class Dados
    {
        private alunos[] vet;
        public Dados()// construtor
        {
           vet = new alunos[50];
        }
        public void inserir(alunos x)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == null)
                {
                    vet[i] = x;
                    break;
                }
            }
        }
        public void listaralunos()
        {
            foreach(alunos x in vet)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3} de {4} de {5}\n", x.nome, x.mail, x.telefone, x.nascimento.dia,x.nascimento.mes,x.nascimento.ano);
            }
        }
    }
}
