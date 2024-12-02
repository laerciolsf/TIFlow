using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.model
{
    public class CadastroChamado
    {
        //Declaração dos atributos
        public int id { get; set; }
        public string titulo { get; set; }
        public int qtde_chamados { get; set; }
        public TimeSpan idqtde_tempo { get; set; }
    }
}
