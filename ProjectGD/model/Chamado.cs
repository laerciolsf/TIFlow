using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.model
{
    public class Chamado
    {
        // Declaração dos atributos
        public int Id { get; set; } // Chave Primária (PK)
        public TimeSpan HoraInicio { get; set; } // Representa hora de início
        public TimeSpan HoraFinal { get; set; } // Representa hora de término
        public string Descricao { get; set; } // Texto com limite de 100 caracteres
        public int IdGrupoChamado { get; set; } // Chave estrangeira (FK para GrupoChamado)
    }
}
