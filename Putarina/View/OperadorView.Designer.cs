namespace Putarina.View
{
    partial class OperadorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperadorView));
            this.label1 = new System.Windows.Forms.Label();
            this.chcCarro = new System.Windows.Forms.CheckBox();
            this.chcMoto = new System.Windows.Forms.CheckBox();
            this.chcCaminhao = new System.Windows.Forms.CheckBox();
            this.txtNeixos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttEnviar = new System.Windows.Forms.Button();
            this.tbcControle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttCalcula = new System.Windows.Forms.Button();
            this.lblPrecopagar = new System.Windows.Forms.Label();
            this.txtPrecoPagar = new System.Windows.Forms.TextBox();
            this.Limpa = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chcCheque = new System.Windows.Forms.CheckBox();
            this.chcCartao = new System.Windows.Forms.CheckBox();
            this.chcDinheiro = new System.Windows.Forms.CheckBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.tbcControle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-97, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa ";
            // 
            // chcCarro
            // 
            this.chcCarro.AutoSize = true;
            this.chcCarro.Location = new System.Drawing.Point(34, 106);
            this.chcCarro.Name = "chcCarro";
            this.chcCarro.Size = new System.Drawing.Size(67, 24);
            this.chcCarro.TabIndex = 1;
            this.chcCarro.Text = "Carro";
            this.chcCarro.UseVisualStyleBackColor = true;
            this.chcCarro.CheckedChanged += new System.EventHandler(this.chcCarro_CheckedChanged);
            // 
            // chcMoto
            // 
            this.chcMoto.AutoSize = true;
            this.chcMoto.Location = new System.Drawing.Point(34, 145);
            this.chcMoto.Name = "chcMoto";
            this.chcMoto.Size = new System.Drawing.Size(64, 24);
            this.chcMoto.TabIndex = 2;
            this.chcMoto.Text = "Moto";
            this.chcMoto.UseVisualStyleBackColor = true;
            this.chcMoto.CheckedChanged += new System.EventHandler(this.chcMoto_CheckedChanged);
            // 
            // chcCaminhao
            // 
            this.chcCaminhao.AutoSize = true;
            this.chcCaminhao.Location = new System.Drawing.Point(35, 185);
            this.chcCaminhao.Name = "chcCaminhao";
            this.chcCaminhao.Size = new System.Drawing.Size(100, 24);
            this.chcCaminhao.TabIndex = 3;
            this.chcCaminhao.Text = "Caminhão";
            this.chcCaminhao.UseVisualStyleBackColor = true;
            this.chcCaminhao.CheckedChanged += new System.EventHandler(this.chcCaminhao_CheckedChanged);
            // 
            // txtNeixos
            // 
            this.txtNeixos.Location = new System.Drawing.Point(34, 244);
            this.txtNeixos.Name = "txtNeixos";
            this.txtNeixos.Size = new System.Drawing.Size(127, 26);
            this.txtNeixos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de eixos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bttEnviar
            // 
            this.bttEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEnviar.Location = new System.Drawing.Point(526, 262);
            this.bttEnviar.Name = "bttEnviar";
            this.bttEnviar.Size = new System.Drawing.Size(93, 37);
            this.bttEnviar.TabIndex = 5;
            this.bttEnviar.Text = "Recebido";
            this.bttEnviar.UseVisualStyleBackColor = true;
            this.bttEnviar.Click += new System.EventHandler(this.bttEnviar_Click);
            // 
            // tbcControle
            // 
            this.tbcControle.AccessibleName = "";
            this.tbcControle.Controls.Add(this.tabPage1);
            this.tbcControle.Location = new System.Drawing.Point(12, 12);
            this.tbcControle.Name = "tbcControle";
            this.tbcControle.SelectedIndex = 0;
            this.tbcControle.Size = new System.Drawing.Size(642, 366);
            this.tbcControle.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPlaca);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.bttCalcula);
            this.tabPage1.Controls.Add(this.lblPrecopagar);
            this.tabPage1.Controls.Add(this.txtPrecoPagar);
            this.tabPage1.Controls.Add(this.Limpa);
            this.tabPage1.Controls.Add(this.lblPlaca);
            this.tabPage1.Controls.Add(this.bttEnviar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chcDinheiro);
            this.tabPage1.Controls.Add(this.chcCarro);
            this.tabPage1.Controls.Add(this.txtNeixos);
            this.tabPage1.Controls.Add(this.chcCartao);
            this.tabPage1.Controls.Add(this.chcMoto);
            this.tabPage1.Controls.Add(this.chcCheque);
            this.tabPage1.Controls.Add(this.chcCaminhao);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passe CATRACA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bttCalcula
            // 
            this.bttCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCalcula.Location = new System.Drawing.Point(38, 276);
            this.bttCalcula.Name = "bttCalcula";
            this.bttCalcula.Size = new System.Drawing.Size(81, 33);
            this.bttCalcula.TabIndex = 12;
            this.bttCalcula.Text = "Calcular";
            this.bttCalcula.UseVisualStyleBackColor = true;
            this.bttCalcula.Click += new System.EventHandler(this.bttCalcula_Click);
            // 
            // lblPrecopagar
            // 
            this.lblPrecopagar.AutoSize = true;
            this.lblPrecopagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecopagar.Location = new System.Drawing.Point(399, 39);
            this.lblPrecopagar.Name = "lblPrecopagar";
            this.lblPrecopagar.Size = new System.Drawing.Size(50, 20);
            this.lblPrecopagar.TabIndex = 11;
            this.lblPrecopagar.Text = "Preço";
            // 
            // txtPrecoPagar
            // 
            this.txtPrecoPagar.Location = new System.Drawing.Point(403, 62);
            this.txtPrecoPagar.Name = "txtPrecoPagar";
            this.txtPrecoPagar.ReadOnly = true;
            this.txtPrecoPagar.Size = new System.Drawing.Size(118, 26);
            this.txtPrecoPagar.TabIndex = 10;
            // 
            // Limpa
            // 
            this.Limpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpa.Location = new System.Drawing.Point(403, 262);
            this.Limpa.Name = "Limpa";
            this.Limpa.Size = new System.Drawing.Size(88, 37);
            this.Limpa.TabIndex = 9;
            this.Limpa.Text = "Limpar";
            this.Limpa.UseVisualStyleBackColor = true;
            this.Limpa.Click += new System.EventHandler(this.Limpa_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(31, 39);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 8;
            this.lblPlaca.Text = "Placa";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(637, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 29);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chcCheque
            // 
            this.chcCheque.AutoSize = true;
            this.chcCheque.Location = new System.Drawing.Point(186, 185);
            this.chcCheque.Name = "chcCheque";
            this.chcCheque.Size = new System.Drawing.Size(84, 24);
            this.chcCheque.TabIndex = 3;
            this.chcCheque.Text = "Cheque";
            this.chcCheque.UseVisualStyleBackColor = true;
            this.chcCheque.CheckedChanged += new System.EventHandler(this.chcCheque_CheckedChanged);
            // 
            // chcCartao
            // 
            this.chcCartao.AutoSize = true;
            this.chcCartao.Location = new System.Drawing.Point(185, 145);
            this.chcCartao.Name = "chcCartao";
            this.chcCartao.Size = new System.Drawing.Size(76, 24);
            this.chcCartao.TabIndex = 2;
            this.chcCartao.Text = "Cartão";
            this.chcCartao.UseVisualStyleBackColor = true;
            this.chcCartao.CheckedChanged += new System.EventHandler(this.chcCartao_CheckedChanged);
            // 
            // chcDinheiro
            // 
            this.chcDinheiro.AutoSize = true;
            this.chcDinheiro.Location = new System.Drawing.Point(185, 106);
            this.chcDinheiro.Name = "chcDinheiro";
            this.chcDinheiro.Size = new System.Drawing.Size(87, 24);
            this.chcDinheiro.TabIndex = 1;
            this.chcDinheiro.Text = "Dinheiro";
            this.chcDinheiro.UseVisualStyleBackColor = true;
            this.chcDinheiro.CheckedChanged += new System.EventHandler(this.chcDinheiro_CheckedChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(34, 62);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(127, 26);
            this.txtPlaca.TabIndex = 14;
            // 
            // OperadorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(666, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbcControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperadorView";
            this.Text = "Operador";
            this.tbcControle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chcCarro;
        private System.Windows.Forms.CheckBox chcMoto;
        private System.Windows.Forms.CheckBox chcCaminhao;
        private System.Windows.Forms.TextBox txtNeixos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttEnviar;
        private System.Windows.Forms.TabControl tbcControle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button Limpa;
        private System.Windows.Forms.Label lblPrecopagar;
        private System.Windows.Forms.TextBox txtPrecoPagar;
        private System.Windows.Forms.Button bttCalcula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chcDinheiro;
        private System.Windows.Forms.CheckBox chcCartao;
        private System.Windows.Forms.CheckBox chcCheque;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
    }
}