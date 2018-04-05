using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Q2_POO
{
    class Dados
    {
    private ArrayList cad;
    public Dados()// construtor
    {
        cad = new ArrayList();
    }
    public void inserir(alunos x)
    {
        cad.Add(x);
    }
    public ArrayList listaralunos()
    {
        return cad;
    }
    }
}
