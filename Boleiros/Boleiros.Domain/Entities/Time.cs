using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class Time : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual IList<Jogo> JogosMandante { get; set; }
        public virtual IList<Jogo> JogosVisitante { get; set; }
    }
}
