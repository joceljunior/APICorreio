using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebServiceCorreio
{
    using BuscaCEP;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CEP desejado: ");
            var cep = Console.ReadLine();

            if(!string.IsNullOrEmpty(cep))
            {
                ConsultaCEP(cep);
            }
        }

        private static void ConsultaCEP(string cep)
        {
            using (var ws = new AtendeClienteClient()) // referencia nova isntancia de metodo do webService
            {
                var resposta = ws.consultaCEP(cep); // chama metodo do webService para consulta cep procurado

                Console.Clear();
                Console.WriteLine(string.Format("Endereço: {0}", resposta.end));
                Console.WriteLine(string.Format("Bairro: {0}", resposta.bairro));
                Console.WriteLine(string.Format("Cidade: {0}", resposta.cidade));
                Console.WriteLine(string.Format("UF: {0}", resposta.uf));
                Console.WriteLine(string.Format("CEP: {0}", resposta.cep));
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
        
    }
}
