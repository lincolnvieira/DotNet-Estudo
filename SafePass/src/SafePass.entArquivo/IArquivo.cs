using SafePass.Models;
using System;

namespace SafePass.entArquivo
{
    public interface IArquivo
    {
        void Gravar();
        Usuario Buscar(string email, string senha);
        bool Deletar();
    }
}
