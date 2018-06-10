using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class TimeLiga : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int IdLiga { get; set; }
        public virtual TimeLiga Time { get; set; }
    }
}
