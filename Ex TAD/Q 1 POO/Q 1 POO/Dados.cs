using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Q_1_POO
{
    class Dados
    {
        private ArrayList cad; 
        public Dados()
        {
            cad = new ArrayList();
        }
        public void inserir(alunos x)
        {
            cad.Add(x);
        }
        public ArrayList listaralunos ()
        {
            return cad;
        }
    }
}
