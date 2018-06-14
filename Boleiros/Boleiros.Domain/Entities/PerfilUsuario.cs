using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Domain.Entities
{
    public class PerfilUsuario
    {
        public int Id { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Bolao Bolao { get; set; }
    }
}
