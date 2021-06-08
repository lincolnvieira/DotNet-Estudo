using System;
using System.Collections.Generic;
using System.Text;

namespace SafePass.Models
{
    public class Conta
    {
        public int Conta_ID { get; set; }
        public string LocalConta { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
