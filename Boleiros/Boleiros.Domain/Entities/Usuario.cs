using Boleiros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual IList<PerfilUsuario> PerfisUsuario { get; set; }
        public virtual IList<Palpite> Palpites{ get; set; }
    }
}
