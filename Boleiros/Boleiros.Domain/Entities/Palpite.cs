using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class Palpite : IEntity
    {
        public int NumeroGolMandante { get; set; }
        public int NumeroGolVisitante { get; set; }
        public int IdJogo { get; set; }
        public int IdUsuario { get; set; }
        public virtual Jogo Jogo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
