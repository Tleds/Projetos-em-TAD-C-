using System;
using System.Collections.Generic;
using System.Text;

namespace Q_5_TAD
{
    class veiculos
    {
    public string placa { get; set; }
    public string marca { get; set; }
    public string modelo { get; set; }
    public string anofab { get; set; }
    public double valorkm { get; set; }
    public int kminicial { get; set; }
    public int kmfinal { get; set; }
    public double calclocacao ()
    {
        return valorkm * (kmfinal - kminicial);
    }
}
}
