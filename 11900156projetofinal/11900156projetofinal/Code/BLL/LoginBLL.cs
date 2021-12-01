using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _11900156projetofinal.Code.DTO; 
using _11900156projetofinal.Code.DAL;
namespace _11900156projetofinal.Code.BLL
{
    class LoginBLL
    {
        AcessoAoBanco conexao = new AcessoAoBanco();
        string tabela = "usuario";

        public bool RealizarLogin(LoginDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}' and cpf='{login.Cpf}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
