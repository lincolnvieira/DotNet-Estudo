using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Eventos
{
    public static class Validacoes
    {

        public static decimal ValidarDecimal(this string valor, string msg)
        {
            try
            {
                return Convert.ToDecimal(valor);
            }
            catch (Exception)
            {
                throw new Exception(msg);
            }
        }
    }
}
