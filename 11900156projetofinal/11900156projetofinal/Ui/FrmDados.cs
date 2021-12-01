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
    public partial class FrmDados : Form
    {
        DadosBLL medbll = new DadosBLL();
        DadosDTO meddto = new DadosDTO();
        public FrmDados()
        {
            InitializeComponent();
        }

        private void FrmDados_Load(object sender, EventArgs e)
        {
            DgvDados.DataSource = medbll.Listar();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Gpm = TxtGpm.Text;
            meddto.G12 = TxtG12.Text;
            meddto.M13 = TxtM13.Text;


            if (TxtGpm.Text != "" || TxtG12.Text != "" || TxtM13.Text != "")
            {
                //Envio do dto preenchido para o método inserir
                medbll.Inserir(meddto);

                //Mensagem de sucesso
                MessageBox.Show("Cadastrado com sucesso!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpeza dos componentes
                TxtId.Clear();
                TxtGpm.Clear();
                TxtG12.Clear();
                TxtM13.Clear();

            }
            else
            {
                //Mensagem de erro
                MessageBox.Show("Erro, preencha todos os campos!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = DgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtGpm.Text = DgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtG12.Text = DgvDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtM13.Text = DgvDados.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(TxtId.Text);
            meddto.Gpm = (TxtGpm.Text);
            meddto.G12 = (TxtG12.Text);
            meddto.M13 = (TxtM13.Text);

            //Envio do dto preenchido para método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            TxtId.Clear();
            TxtGpm.Clear();
            TxtG12.Clear();
            TxtM13.Clear();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(TxtId.Text);

            //Envio do dto preenchido para o método excluir
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            TxtId.Clear();
            TxtGpm.Clear();
            TxtG12.Clear();
            TxtM13.Clear();
        }
    }
}
