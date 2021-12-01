using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11900156projetofinal.Code.DTO; 
using _11900156projetofinal.Code.DAL;
using System.Data;

namespace _11900156projetofinal.Code.BLL
{
    class CadastroUsuarioBLL
    {
        AcessoAoBanco conexao = new AcessoAoBanco();
        string tabela = "usuario";

        public void Inserir(CadastroUsuarioDTO medDto)
        {
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome}','{medDto.Telefone}','{medDto.Rua}','{medDto.Numero}','{medDto.Bairro}','{medDto.Cidade}','{medDto.Estado}','{medDto.Pais}','{medDto.Cpf}','{medDto.Rg}','{medDto.Data_De_Nascimento}','{medDto.Email}','{medDto.Senha}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()  
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(CadastroUsuarioDTO meddDto)
        {
            string alterar = $"update {tabela} set nome = '{meddDto.Nome}', telefone = '{meddDto.Telefone}', rua = '{meddDto.Rua}', numero = '{meddDto.Numero}', bairro = '{meddDto.Bairro}', cidade = '{meddDto.Cidade}', estado = '{meddDto.Estado}', pais = '{meddDto.Pais}', cpf = '{meddDto.Cpf}', rg = '{meddDto.Rg}', datanascimento = '{meddDto.Data_De_Nascimento}', email = '{meddDto.Email}', senha = '{meddDto.Senha}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(CadastroUsuarioDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
