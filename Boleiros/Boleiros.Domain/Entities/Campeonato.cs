using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class Campeonato : IEntity
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual IList<Rodada> Rodadas { get; set; }
        public virtual IList<Bolao> Boloes { get; set; }
    }
}
