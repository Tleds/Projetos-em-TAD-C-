using System;
using System.Collections.Generic;
using System.Text;

namespace Q_5_TAD
{
    class Carga:veiculos
    {
    public double capcarga { get; set; }
    public double calclocacao()
    {
        return base.calclocacao() * 1.1; // se refere a funcao de origem e this se refere a esta função;
    }
}
}
