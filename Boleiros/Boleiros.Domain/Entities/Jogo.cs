using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class Jogo : IEntity
    {
        public int Id { get; set; }
        public int IdMandante { get; set; }
        public int IdVisitante { get; set; }
        public int NumeroGolMandante { get; set; }
        public int NumeroGolVisitante { get; set; }
        public int IdRodada { get; set; }
        public virtual Rodada Rodada { get; set; }
        public bool Ativo { get; set; }
    }
}
