using System;

namespace Q_5_TAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Carga[] cadcarga = new Carga[1];
            Carga minhacarga;
            for (int i = 0; i < 1; i++)
            {
                minhacarga = new Carga();
                Console.WriteLine("Placa: ");
                minhacarga.placa = Console.ReadLine();
                Console.WriteLine("Marca: ");
                minhacarga.marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                minhacarga.modelo = Console.ReadLine();
                Console.WriteLine("Ano de Fabricação: ");
                minhacarga.anofab = Console.ReadLine();
                Console.WriteLine("Valor por KM rodado: ");
                minhacarga.valorkm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Km Inicial: ");
                minhacarga.kminicial = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Km Final: ");
                minhacarga.kmfinal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Capacidade de carga: ");
                minhacarga.capcarga = Convert.ToDouble(Console.ReadLine());
                cadcarga[i] = minhacarga;
            }
            Console.Clear();
            foreach (Carga x in cadcarga)
            {
                Console.WriteLine("{0} - {1}", x.placa, x.modelo);
                Console.WriteLine("{0:F2}", x.calclocacao());
            }
            Console.ReadKey();
        }
    }
}
