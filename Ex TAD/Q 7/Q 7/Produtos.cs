using System;
using System.Collections.Generic;
using System.Text;

namespace Q_7
{
    class Produtos
    {
        private Categorias _categoria;

        public Categorias categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private string _nome;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _qtdadeemestoque;

        public int qtdadeemestoque
        {
            get { return _qtdadeemestoque; }
            set { _qtdadeemestoque = value; }
        }

        private double _preco;

        public double preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

       public Produtos()
        {
            _nome = "";
          _qtdadeemestoque = 0;
          _preco = 0.0;
        }
    }
}
