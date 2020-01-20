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

namespace Putarina.View
{
    public partial class AdministradorView : Form
    {
        int id, id_praca;
        int RowSelect;
        OperadorRepository operadorrepository = new OperadorRepository();
        registro_veiculoRepository RVR = new registro_veiculoRepository();
        PracaRepository PR = new PracaRepository();
        public AdministradorView()
        {
            InitializeComponent();
            atualizaGRD();
        }
        public void atualizaGRD(){
            grdDadosOperadores.DataSource = operadorrepository.GetAll();
            grdRegistrosPassagem.DataSource = RVR.GetAll();
            grdPraca.DataSource = PR.GetAll();
        }
        private void bttSalvar_Click(object sender, EventArgs e)
        {
            usuario operador = operadorrepository.GetPS(txtUsuario.Text);
            if(operador != null)
            {
                MessageBox.Show("Usuario e/ou Senha conflitantes no sistemas");
                return;
            }
            if (string.IsNullOrEmpty(txtProcurarID.Text))
            {
                operador = new usuario();
                operador.nome = txtNome.Text;
                operador.nickusuario = txtUsuario.Text;
                operador.senha = txtSenha.Text;
                operador.ativo = chcAtivo.Checked;
                operador.data_nascimento = dttDataNascimento.Value;
                operador.catraca = int.Parse(txtEstacaoTrabalho.Text);
                operador.id_praca = int.Parse(cmbPraca.SelectedValue.ToString());
                //operador.id_praca = 01;//cmbPraca.SelectedValue.ToString();
                //operador.tipo = chcCargo.CheckOnClick.ToString();
                if (chcCargoADM.Checked == true)
                {
                    operador.tipo = "Administrador";
                }
                else if(chcCargoOperador.Checked == true){
                    operador.tipo = "Operador";
                }
                operadorrepository.Salvar(operador);
                grdDadosOperadores.DataSource = operadorrepository.GetAll();
            }
            else
            {
                bttAlterarUsuario_Click(null,null);
            }
            bttLimpa_Click(null, null);
        }

        private void bttLimpa_Click(object sender, EventArgs e)
        {
            chcCargoADM.Checked = false;
            chcCargoOperador.Checked = false;
            txtNome.Text = null;
            txtEstacaoTrabalho.Text = null;
            txtProcurarID.Text = null;
            txtSenha.Text = null;
            txtUsuario.Text = null;
            chcAtivo.Checked = false;
            dttDataNascimento.Value = DateTime.Now;
            grdDadosOperadores.DataSource = operadorrepository.GetAll();
        }

        private void bttProcurarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProcurarID.Text))
            {
                MessageBox.Show("Campo de procura por id esta vazio");
                atualizaGRD();
                return;
            }
            else
            {
                BindingSource source = new BindingSource();
                usuario Usuario = operadorrepository.GetOne(int.Parse(txtProcurarID.Text));
                source.DataSource = Usuario;
                if (Usuario != null)
                {
                    grdDadosOperadores.DataSource = source;
                }
                else
                {
                    MessageBox.Show("ID não existe no estado atual");
                    atualizaGRD();
                    return;
                }
            }
            
        }

        private void grdDadosOperadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (RowSelect == -1)
            {
                MessageBox.Show("Lista Vazia");
            }
            else
            {
                txtNome.Text = grdDadosOperadores.CurrentRow.Cells["nome"].Value.ToString();
                txtUsuario.Text = grdDadosOperadores.CurrentRow.Cells["usuario1"].Value.ToString();
                txtSenha.Text = grdDadosOperadores.CurrentRow.Cells["senha"].Value.ToString();
                chcAtivo.Checked = bool.Parse(grdDadosOperadores.CurrentRow.Cells["ativo"].Value.ToString());
                dttDataNascimento.Value = DateTime.Parse(grdDadosOperadores.CurrentRow.Cells["data_nascimento"].Value.ToString());
                id = int.Parse(grdDadosOperadores.CurrentRow.Cells["id_usuario"].Value.ToString());
                txtProcurarID.Text = grdDadosOperadores.CurrentRow.Cells["id_usuario"].Value.ToString();
                txtEstacaoTrabalho.Text =  grdDadosOperadores.CurrentRow.Cells["catraca"].Value.ToString();
                cmbPraca.Text = grdDadosOperadores.CurrentRow.Cells["id_praca"].Value.ToString();
                if ((grdDadosOperadores.CurrentRow.Cells["tipo"].Value).Equals("Administrador"))
                {
                    chcCargoADM.Checked = true;
                    chcCargoOperador.Checked = false;
                }
                else if ((grdDadosOperadores.CurrentRow.Cells["tipo"].Value).Equals("Operador"))
                {
                    chcCargoOperador.Checked = true;
                    chcCargoADM.Checked = false;
                }
            }*/
        }

        private void grdDadosOperadores_SelectionChanged(object sender, EventArgs e)
        {
            RowSelect = grdDadosOperadores.CurrentCell.RowIndex;
        }

        private void bttAlterarUsuario_Click(object sender, EventArgs e)
        {
            usuario Usuario;
            if (string.IsNullOrEmpty(txtProcurarID.Text))
            {
                MessageBox.Show("Digite o ID do Usuario que deseja alterar na procura por ID");
                return;
            }
            Usuario = operadorrepository.GetOne(int.Parse(txtProcurarID.Text));
            if (Usuario == null)
            {
                MessageBox.Show("Usuario invalido/inexistente... (tente pesquisar antes de alterar)");
                return;
            }
            Usuario.nome = txtNome.Text;
            Usuario.nickusuario = txtUsuario.Text;
            Usuario.senha = txtSenha.Text;
            Usuario.ativo = chcAtivo.Checked;
            Usuario.data_nascimento = dttDataNascimento.Value;
            Usuario.catraca = int.Parse(txtEstacaoTrabalho.Text);
            Usuario.id_praca = int.Parse(cmbPraca.SelectedValue.ToString());
            if (chcCargoADM.Checked == true)
            {
                Usuario.tipo = "Administrador";
            }
            else if (chcCargoOperador.Checked == true)
            {
                Usuario.tipo = "Operador";
            }
            else
            {
                MessageBox.Show("Tipo de cargo nao selecionado");
            }
            operadorrepository.Salvar(Usuario);
            grdDadosOperadores.DataSource = operadorrepository.GetAll();
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProcurarID.Text))
            {
                MessageBox.Show("O ID do Usuario a ser desativado deve ser inserido na procura por ID");
                return;
            }
            usuario operador = operadorrepository.GetOne(int.Parse(txtProcurarID.Text));
            if (operador != null)
            {
                if (operador.ativo == true)
                {
                    var result = MessageBox.Show("Você deseja Desativar este Usuario?", "Alterar Usuario", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        operador.ativo = false;
                        operadorrepository.Salvar(operador);
                    }
                }
                else
                {
                    MessageBox.Show("Operador já está desativo");
                    var result = MessageBox.Show("Você deseja ativar este Usuario?", "Alterar Usuario", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        operador.ativo = true;
                        operadorrepository.Salvar(operador);
                    }
                }
            }
            
            grdDadosOperadores.DataSource = operadorrepository.GetAll();
        }

        private void bttAtualizaOperadores_Click(object sender, EventArgs e)
        {
            atualizaGRD();
        }

        private void bttAtualizaVeiculosRegistro_Click(object sender, EventArgs e)
        {
            atualizaGRD();
        }

        private void chcCargoADM_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCargoADM.Checked == true)
            {
                chcCargoOperador.Checked = false;
            }
        }

        private void chcCargoOperador_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCargoOperador.Checked == true)
            {
                chcCargoADM.Checked = false;
            }
        }

        private void AdministradorView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.registro_veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.registro_veiculoTableAdapter.Fill(this.database1DataSet.registro_veiculo);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.praca'. Você pode movê-la ou removê-la conforme necessário.
            this.pracaTableAdapter.Fill(this.database1DataSet.praca);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.database1DataSet.usuario);
            // TODO: This line of code loads data into the 'dataBaseDataSet.veiculo' table. You can move, or remove it, as needed.
            

        }

        private void bttSalvarPraca_Click(object sender, EventArgs e)
        {
            praca Praca = new praca();
            Praca.cidade = txtCidade.Text;
            Praca.localizacao = txtLocalizacao.Text;
            Praca.qtd_catracas = int.Parse(txtQtd_Catraca.Text);
            Praca.preco_moto = float.Parse(txtPrecoMoto.Text);
            Praca.preco_carro_passeio = float.Parse(txtprecoCarro.Text);
            Praca.preco_caminhao = float.Parse(txtprecoCaminhao.Text);

            PR.Salvar(Praca);
            atualizaGRD();
        }

        private void grdPraca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCidade.Text = grdPraca.CurrentRow.Cells["cidade"].Value.ToString();
            txtLocalizacao.Text = grdPraca.CurrentRow.Cells["localizacao"].Value.ToString();
            txtQtd_Catraca.Text = grdPraca.CurrentRow.Cells["qtd_catracas"].Value.ToString();
            id_praca = int.Parse(grdPraca.CurrentRow.Cells["id_praca"].Value.ToString());
            txtProcurarIdPraca.Text = grdPraca.CurrentRow.Cells["id_praca"].Value.ToString();
            txtPrecoMoto.Text = grdPraca.CurrentRow.Cells["preco_moto"].Value.ToString();
            txtprecoCarro.Text = grdPraca.CurrentRow.Cells["preco_carro_passeio"].Value.ToString();
            txtprecoCaminhao.Text = grdPraca.CurrentRow.Cells["preco_caminhao"].Value.ToString();
        }

        private void bttAlterarPraca_Click(object sender, EventArgs e)
        {
            praca Praca = PR.GetOne(id_praca);
            Praca.cidade = txtCidade.Text;
            Praca.localizacao = txtLocalizacao.Text;
            Praca.qtd_catracas = int.Parse(txtQtd_Catraca.Text);
            Praca.preco_moto = float.Parse(txtPrecoMoto.Text);
            Praca.preco_carro_passeio = float.Parse(txtprecoCarro.Text);
            Praca.preco_caminhao = float.Parse(txtprecoCaminhao.Text);

            PR.Salvar(Praca);
            atualizaGRD();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCidade.Text = "";
            txtLocalizacao.Text = "";
            txtQtd_Catraca.Text = "";
            txtPrecoMoto.Text = "";
            txtprecoCarro.Text = "";
            txtprecoCaminhao.Text = "";
            atualizaGRD();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            atualizaGRD();
        }

        private void bttPesquisarIdPraca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProcurarIdPraca.Text))
            {
                MessageBox.Show("Campo de procura por id esta vazio");
                atualizaGRD();
                return;
            }
            else
            {
                BindingSource source = new BindingSource();
                praca Praca = PR.GetOne(int.Parse(txtProcurarIdPraca.Text));
                source.DataSource = Praca;
                if (Praca != null)
                {
                    grdDadosOperadores.DataSource = source;
                }
                else
                {
                    MessageBox.Show("ID não existe no estado atual");
                    atualizaGRD();
                    return;
                }
            }
        }

        private void bttAbrir_Click(object sender, EventArgs e)
        {
            OperadorView view = new OperadorView();
            view.ShowDialog();
        }

        private void bttFilter_Click(object sender, EventArgs e)
        {
            List<registro_veiculo> listaveiculo = RVR.GetAll();
            DateTime datamin = DateTime.Parse(dttDatamin.Value.ToString("dd/MM/yyyy") + " " + dttHoramin.Value.ToString("HH:mm"));
            DateTime datamax = DateTime.Parse(dttDatamax.Value.ToString("dd/MM/yyyy") + " " + dttHoramax.Value.ToString("HH:mm"));
            string forma = "";
            if (chcCartao.Checked == true)
            {
                forma = "cartão";
            }
            if (chcDinheiro.Checked == true)
            {
                forma = "dinheiro";
            }
            if (chcCheque.Checked == true)
            {
                forma = "cheque";
            }

            if (forma != "")
            {
                if (chcPesquisarData.Checked)
                    listaveiculo = RVR.GetAll(datamin, datamax, forma);
                else
                    listaveiculo = RVR.GetAll(forma);
            }
            else
            {
                if(chcPesquisarData.Checked)
                    listaveiculo = RVR.GetAll(datamin, datamax);
            }
            grdRegistrosPassagem.DataSource = listaveiculo;
            
        }
        public void limpar()
        {
            chcDinheiro.Checked = false;
            chcCartao.Checked = false;
            chcCheque.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
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
