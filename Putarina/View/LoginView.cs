using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Putarina.Repository;
using Putarina.Model;
using Putarina.Sessao;

namespace Putarina.View
{
    public partial class LoginView : Form
    {
        OperadorRepository operadorrepository = new OperadorRepository();
        public LoginView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            usuario login = operadorrepository.GetPS(txtUsuario.Text);
            
            if(login == null)
            {
                MessageBox.Show("Usuario nao encontrado bejos de luz");
                return;
            }
            if(txtUsuario.Text == login.nickusuario && txtSenha.Text == login.senha)
            {
                if(login.ativo == true)
                {
                    if (login.tipo.Equals("Operador"))
                    {
                        OperadorView operadorview = new OperadorView();
                        SessaoSistema.UsuarioId = login.id_usuario;
                        SessaoSistema.PracaUsuario = login.id_praca;
                        this.Hide();
                        operadorview.ShowDialog();
                        Application.Exit();
                    }
                    else if (login.tipo.Equals("Administrador"))
                    {
                        AdministradorView administradorview = new AdministradorView();
                        SessaoSistema.UsuarioId = login.id_usuario;
                        SessaoSistema.PracaUsuario = login.id_praca;
                        this.Hide();
                        administradorview.ShowDialog();
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Desativado");
                }
            }
            else
            {
                MessageBox.Show("Usuario ou Senha não conferem");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
