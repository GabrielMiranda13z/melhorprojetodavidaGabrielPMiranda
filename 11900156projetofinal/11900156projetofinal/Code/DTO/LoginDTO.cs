using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11900156projetofinal.Code.DTO
{
    class LoginDTO
    {
        private string _email;
        private string _senha;
        private string _cpf;

        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
    }
}
