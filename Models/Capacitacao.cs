using System;

namespace Masp.Models
{
    public class Capacitacao
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CaminhoEscudo { get; set; }
        public bool Particular { get; set; }
        public string UF { get; set; }
    }
}
