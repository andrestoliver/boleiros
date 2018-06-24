using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class Jogo : IEntity
    {
        public int Id { get; set; }
        public virtual Rodada Rodada { get; set; }
        public virtual Time Mandante { get; set; }
        public virtual Time Visitante { get; set; }
        public virtual IList<Palpite> Palpites { get; set; }
        public bool Ativo { get; set; }
    }
}
