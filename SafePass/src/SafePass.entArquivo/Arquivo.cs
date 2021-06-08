using SafePass.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafePass.entArquivo
{
    public class Arquivo : IArquivo
    {

        public virtual Usuario Buscar(string teste, string senha)
        {

            return new Usuario();
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public void Gravar()
        {
            throw new NotImplementedException();
        }
    }
}
