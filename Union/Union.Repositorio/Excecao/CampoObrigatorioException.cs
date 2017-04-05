using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union.Repositorio.Excecao
{
    public class CampoObrigatorioException : AbstractException
    {
        public CampoObrigatorioException(string mensagem) : base(mensagem)
        {

        }
    }
}
