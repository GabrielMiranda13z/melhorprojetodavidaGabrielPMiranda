using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _11900156projetofinal.Code.BLL;
using _11900156projetofinal.Code.DTO;

namespace _11900156projetofinal.Ui
{
    public partial class FrmCadastroUsuario : Form
    {
        CadastroUsuarioBLL medbll = new CadastroUsuarioBLL();
        CadastroUsuarioDTO meddto = new CadastroUsuarioDTO();
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            DgvCadastro.DataSource = medbll.Listar();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            meddto.Nome = TxtNome.Text;
            meddto.Telefone = TxtTelefone.Text;
            meddto.Rua = TxtRua.Text;
            meddto.Numero = TxtNumero.Text;
            meddto.Bairro = TxtBairro.Text;
            meddto.Cidade = TxtCidade.Text;
            meddto.Estado = TxtEstado.Text;
            meddto.Pais = TxtPais.Text;
            meddto.Cpf = TxtCpf.Text;
            meddto.Rg = TxtRg.Text;
            meddto.Data_De_Nascimento = TxtDataNascimento.Text;
            meddto.Email = TxtEmail.Text;
            meddto.Senha = TxtSenha.Text;

            if (TxtNome.Text != "" || TxtTelefone.Text != "" || TxtRua.Text != "" || TxtNumero.Text != "" || TxtBairro.Text != "" || TxtCidade.Text != "" || TxtEstado.Text != "" || TxtPais.Text != "" || TxtCpf.Text != "" || TxtRg.Text != "" || TxtDataNascimento.Text != "" || TxtEmail.Text != "" || TxtSenha.Text != "")
            {
                medbll.Inserir(meddto);

                MessageBox.Show("Cadastrado com sucesso!", "Cadastro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtNome.Clear();
                TxtTelefone.Clear();
                TxtRua.Clear();
                TxtNumero.Clear();
                TxtBairro.Clear();
                TxtCidade.Clear();
                TxtEstado.Clear();
                TxtPais.Clear();
                TxtCpf.Clear();
                TxtRg.Clear();
                TxtDataNascimento.Clear();
                TxtEmail.Clear();
                TxtSenha.Clear();
            }
            else
            {
                //Mensagem de erro
                MessageBox.Show("Erro, preencha todos os campos!", "Cadastro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DgvCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quando o usuario clicar em um registro da lista, os dados serão preenchidos
            TxtId.Text = DgvCadastro.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtNome.Text = DgvCadastro.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtTelefone.Text = DgvCadastro.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtRua.Text = DgvCadastro.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtNumero.Text = DgvCadastro.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtBairro.Text = DgvCadastro.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtCidade.Text = DgvCadastro.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtEstado.Text = DgvCadastro.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtPais.Text = DgvCadastro.Rows[e.RowIndex].Cells[8].Value.ToString();
            TxtCpf.Text = DgvCadastro.Rows[e.RowIndex].Cells[9].Value.ToString();
            TxtRg.Text = DgvCadastro.Rows[e.RowIndex].Cells[10].Value.ToString();
            TxtDataNascimento.Text = DgvCadastro.Rows[e.RowIndex].Cells[11].Value.ToString();
            TxtEmail.Text = DgvCadastro.Rows[e.RowIndex].Cells[12].Value.ToString();
            TxtSenha.Text = DgvCadastro.Rows[e.RowIndex].Cells[13].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(TxtId.Text);
            meddto.Nome = (TxtNome.Text);
            meddto.Telefone = (TxtTelefone.Text);
            meddto.Rua = (TxtRua.Text);
            meddto.Numero = (TxtNumero.Text);
            meddto.Bairro = (TxtBairro.Text);
            meddto.Cidade = (TxtCidade.Text);
            meddto.Estado = (TxtEstado.Text);
            meddto.Pais = (TxtPais.Text);
            meddto.Cpf = (TxtCpf.Text);
            meddto.Rg = (TxtRg.Text);
            meddto.Data_De_Nascimento = (TxtDataNascimento.Text);
            meddto.Email = (TxtEmail.Text);
            meddto.Senha = (TxtSenha.Text);

            //Envio do dto preenchido para método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Cadastro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            TxtNome.Clear();
            TxtTelefone.Clear();
            TxtRua.Clear();
            TxtNumero.Clear();
            TxtBairro.Clear();
            TxtCidade.Clear();
            TxtEstado.Clear();
            TxtPais.Clear();
            TxtCpf.Clear();
            TxtRg.Clear();
            TxtDataNascimento.Clear();
            TxtEmail.Clear();
            TxtSenha.Clear();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(TxtId.Text);

            //Envio do dto preenchido para o método excluir
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Cadastro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            TxtNome.Clear();
            TxtTelefone.Clear();
            TxtRua.Clear();
            TxtNumero.Clear();
            TxtBairro.Clear();
            TxtCidade.Clear();
            TxtEstado.Clear();
            TxtPais.Clear();
            TxtCpf.Clear();
            TxtRg.Clear();
            TxtDataNascimento.Clear();
            TxtEmail.Clear();
            TxtSenha.Clear();
        }

        private void BtnIr_Click(object sender, EventArgs e)
        {
            FrmDados dados = new FrmDados();
            dados.Show();
        }
    }
}
