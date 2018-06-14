using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class Rodada : IEntity
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual Campeonato Campeonato { get; set; }
        public virtual IList<Jogo> Jogos { get; set; }
    }
}
