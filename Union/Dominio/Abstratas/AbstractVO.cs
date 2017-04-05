using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Abstratas
{
    public abstract class AbstractVO
    {
        public long Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Selecionado { get; set; }

        public AbstractVO()
        {

        }
    }
}
