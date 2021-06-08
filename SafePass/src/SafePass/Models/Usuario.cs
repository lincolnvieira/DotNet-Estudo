using System;
using System.Collections.Generic;
using System.Text;

namespace SafePass.Models
{
    public class Usuario
    {
        public int Usuario_ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Conta> UsuarioContas { get; set; }
    }
}
