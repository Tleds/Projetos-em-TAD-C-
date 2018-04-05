using System;
using System.Collections.Generic;
using System.Text;

namespace Q_7
{
    class Categorias
    {
        private int _codigo;

        public  int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _descricao;

        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public Categorias()
        {
            codigo = 0;
            descricao = "";
        }
    }
}
