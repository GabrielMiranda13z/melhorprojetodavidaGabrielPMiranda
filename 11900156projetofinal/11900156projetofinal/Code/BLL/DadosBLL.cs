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
    class DadosBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoAoBanco conexao = new AcessoAoBanco();
        string tabela = "dados";

        public void Inserir(DadosDTO medDto)
        {
            string inserir = $"insert into {tabela} values(null,'{medDto.Gpm}','{medDto.G12}','{medDto.M13}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()      
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(DadosDTO meddDto)
        {
            string alterar = $"update {tabela} set gpm = '{meddDto.Gpm}', g12 = '{meddDto.G12}', m13 = '{meddDto.M13}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(DadosDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
