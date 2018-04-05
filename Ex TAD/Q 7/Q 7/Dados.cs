using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;

namespace Q_7
{
    class Dados
    {
        private ArrayList cad;
        public Dados()
        {
            cad = new ArrayList();
        }
        public void inserir(Produtos produtos)
        {
            Produtos x = produtos;
            cad.Add(x);
            escreverjson(cad);
        }
        public ArrayList listar()
        {
            lerjson();
            return cad;
        }
        public void lerjson()
        {
            var json = File.ReadAllText(@"C:\Temp\Produtos.json");
            //var js = new DataContractSerializer(typeof(Produtos));
            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            //var produto = (Produtos)js.ReadObject(ms);
            var produto = JsonConvert.DeserializeObject<List<Produtos>>(json);
        }
        public void escreverjson(ArrayList cad)
        {
            FileStream Arquivo = new FileStream(@"C:\Temp\Produtos.json", FileMode.Open);
            Produtos[] listaalunovetor = (Produtos[])cad.ToArray(typeof(Produtos));
            var json_serializado = JsonConvert.SerializeObject(listaalunovetor);
            Arquivo.Close();
            cad.Clear();
            cad.AddRange(listaalunovetor);
            //var js = new DataContractSerializer(typeof(Produtos));
            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            //var produto = (Produtos)js.ReadObject(ms);
            //var produto = JsonConvert.DeserializeObject<List<Produtos>>(json);
            //var json_serializado = JsonConvert.SerializeObject(cad);
        }
    }
}
