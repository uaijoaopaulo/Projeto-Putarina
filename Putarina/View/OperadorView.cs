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
    public partial class OperadorView : Form
    {
        registro_veiculoRepository RVR = new registro_veiculoRepository();
        VeiculoRepository VR = new VeiculoRepository();
        OperadorRepository OP = new OperadorRepository();

        PracaRepository pracarepository = new PracaRepository();
        praca Praca = new praca();
        public OperadorView()
        {
            InitializeComponent();
            
        }
        
        public void Limpar()
        {
            txtNeixos.Text = null;
            txtPlaca.Text = null;
            txtPrecoPagar.Text = null;
            chcCarro.Checked = false;
            chcMoto.Checked = false;
            chcCaminhao.Checked = false;
            chcCartao.Checked = false;
            chcDinheiro.Checked = false;
            chcCheque.Checked = false;
            
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttEnviar_Click(object sender, EventArgs e)
        {
            double preco = 0;
            Praca = pracarepository.GetOne(SessaoSistema.PracaUsuario);
            registro_veiculo rveiculo = new registro_veiculo();
            veiculo Veiculo = new veiculo();
            Veiculo.placa = txtPlaca.Text;

            if(chcCarro.Checked == true)
            {
                Veiculo.tipo = "Carro";
                preco = Praca.preco_carro_passeio;
            }
            if (chcMoto.Checked == true)
            {
                Veiculo.tipo = "Moto";
                preco = Praca.preco_moto;
            }
            if (chcCaminhao.Checked == true)
            {
                Veiculo.tipo = "Caminhao";
                preco = Praca.preco_caminhao;
            }
            VR.Salvar(Veiculo);

            rveiculo.horario = DateTime.Now;
            rveiculo.id_usuario = SessaoSistema.UsuarioId;
            rveiculo.id_veiculo = Veiculo.id_veiculo;
            rveiculo.preco_pago = preco;
            //rveiculo.usuario = (OP.GetOne(SessaoSistema.UsuarioId));
            //rveiculo.veiculo = VR.GetOne(Veiculo.id_veiculo);
            //rveiculo.forma_pagamento = "Dinheiro";
            if (chcDinheiro.Checked == true)
                rveiculo.forma_pagamento = "Dinheiro";
            else if (chcCheque.Checked == true)
                rveiculo.forma_pagamento = "Cheque";
            else if (chcCartao.Checked == true)
                rveiculo.forma_pagamento = "Cartão";
            RVR.Salvar(rveiculo);

            Limpar();
            Limpar();
        }

        private void chcCarro_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCarro.Checked == true)
            {
                chcMoto.Checked = false;
                chcCaminhao.Checked = false;
            }
            Praca = pracarepository.GetOne(SessaoSistema.PracaUsuario);
            txtPrecoPagar.Text = Praca.preco_carro_passeio.ToString("R$0.00");
        }

        private void chcMoto_CheckedChanged(object sender, EventArgs e)
        {
            if (chcMoto.Checked == true)
            {
                chcCarro.Checked = false;
                chcCaminhao.Checked = false;
            }
            Praca = pracarepository.GetOne(SessaoSistema.PracaUsuario);
            txtPrecoPagar.Text = Praca.preco_moto.ToString("R$0.00");
        }

        private void chcCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCaminhao.Checked == true)
            {
                chcCarro.Checked = false;
                chcMoto.Checked = false;
            }
            txtPrecoPagar.Text = "";
            txtNeixos.Focus();
        }

        private void bttCalcula_Click(object sender, EventArgs e)
        {
            Praca = pracarepository.GetOne(SessaoSistema.PracaUsuario);
            txtPrecoPagar.Text = (int.Parse(txtNeixos.Text) * Praca.preco_caminhao).ToString("R$0.00");
        }

        private void Limpa_Click(object sender, EventArgs e)
        {
            Limpar();
            Limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdministradorView administradorview = new AdministradorView();
            administradorview.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chcDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (chcDinheiro.Checked == true)
            {
                chcCheque.Checked = false;
                chcCartao.Checked = false;
            }
        }

        private void chcCartao_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCartao.Checked == true)
            {
                chcCheque.Checked = false;
                chcDinheiro.Checked = false;
            }
        }

        private void chcCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCheque.Checked == true)
            {
                chcCartao.Checked = false;
                chcDinheiro.Checked = false;
            }
        }
    }
}
