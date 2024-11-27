using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.model
{
    public class Usuario
    {
        //Declaração dos atributos
        public int id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int nivelAcesso { get; set; }
    }
}
