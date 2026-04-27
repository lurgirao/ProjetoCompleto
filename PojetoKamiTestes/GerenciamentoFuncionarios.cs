using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoKamiTestes
{
    public partial class GerenciamentoFuncionarios : Form
    {
        public GerenciamentoFuncionarios()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_cadnome.Text;

            int nascimento = int.Parse(msk_dtnasc.Text);

            int cpf = int.Parse(msk_cadcpf.Text);

            int telefone = int.Parse(msk_tel.Text);

            string email = txt_email.Text;

            int login = int.Parse(msk_login.Text);

            /*string formacaoCadastro = ListaFormacao.SelectedItem.ToString();

            string estadoCivilCadastro = ListaEstadocivil.SelectedItem.ToString();

            string loginCadastro = txtLogin.Text;

            string senhaCadastro = txtSenha.Text;

            string confirmarSenhaCadastro = txtConfirmarSenha.Text;

            usuario usuario = new usuario();

            usuario.Nome = nomeCadastro;

            usuario.Idade = idadeCadastro;

            usuario.Genero = generoCadastro;

            usuario.Cidade = cidadeCadastro;

            usuario.Formacao = formacaoCadastro;

            usuario.EstadoCivil = estadoCivilCadastro;

            usuario.Login = loginCadastro;

            usuario.Senha = senhaCadastro;

            usuarios.Add(usuario);

            MessageBox.Show("Sucesso");*/

        }
    }
}
