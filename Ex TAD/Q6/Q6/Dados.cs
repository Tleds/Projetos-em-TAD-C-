using System;
using System.Collections.Generic;
using System.Text;

namespace Q6
{
    class Dados
    {
        private Filmes[] vet;
        public Dados() // constructor
        {
            vet = new Filmes[100];
        }
        public void inserir(Filmes x)
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
        public void listar()
        {
            foreach (Filmes x in vet)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4}\n\n", x.Nome, x.Categoria, x.Diretor, x.Duraçao, x.AnoEstreia);
                if (x == null)
                    break;
            }
        }
        public void pesquisar(string categoria)
        {
            foreach (Filmes x in vet)
            {
                if (categoria == x.Categoria)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}\n\n", x.Nome, x.Categoria, x.Diretor, x.Duraçao, x.AnoEstreia);
                }
            }
        }

    }
}
