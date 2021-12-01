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
    public partial class FrmLogin : Form
    {
        LoginBLL loginBBL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = TxtEmail.Text;
            loginDTO.Senha = TxtSenha.Text;
            loginDTO.Cpf = TxtCpf.Text;

            if(TxtEmail.Text != "" || TxtSenha.Text != "" || TxtCpf.Text != "")
            {
                //Chamada do método para verificar o acesso: 
                if (loginBBL.RealizarLogin(loginDTO) == true)
                {

                    FrmCadastroUsuario frmCadastro = new FrmCadastroUsuario();
                    frmCadastro.ShowDialog();
                }
                else
                {
                    //Mensagem de sucesso
                    MessageBox.Show("Verifique e-mail, senha e cpf.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Erro, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
