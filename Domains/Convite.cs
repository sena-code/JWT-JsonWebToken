using System;
using System.Collections.Generic;

namespace Nyous.Domains
{
    public partial class Convite
    {
        public int IdConvite { get; set; }
        public bool? Confirmado { get; set; }
        public int? IdUsuarioEmissor { get; set; }
        public int? IdUsuariConvidado { get; set; }
        public int? IdEvento { get; set; }

        public virtual Eventos IdEventoNavigation { get; set; }
        public virtual Usuario IdUsuariConvidadoNavigation { get; set; }
        public virtual Usuario IdUsuarioEmissorNavigation { get; set; }
    }
}
