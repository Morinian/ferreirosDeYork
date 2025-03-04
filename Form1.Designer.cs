namespace ferreirosDeYork
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.btnListarPartida = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblPartidaId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblJogadoresNaPartida = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeCriarPartida = new System.Windows.Forms.TextBox();
            this.lblNomeCriarPartida = new System.Windows.Forms.Label();
            this.lblSenhaCriarPartida = new System.Windows.Forms.Label();
            this.txtSenhaCriarPartida = new System.Windows.Forms.TextBox();
            this.lblNomeGrupoCriarPartida = new System.Windows.Forms.Label();
            this.txtNomeGrupoCriarPartida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bntCriarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarPartida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarPartida.Location = new System.Drawing.Point(94, 631);
            this.btnListarPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarPartida.Name = "btnListarPartida";
            this.btnListarPartida.Size = new System.Drawing.Size(381, 74);
            this.btnListarPartida.TabIndex = 0;
            this.btnListarPartida.Text = "Listar Partidas";
            this.btnListarPartida.UseVisualStyleBackColor = false;
            this.btnListarPartida.Click += new System.EventHandler(this.btnListarPartida_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 23;
            this.lstPartidas.Location = new System.Drawing.Point(93, 252);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(379, 349);
            this.lstPartidas.TabIndex = 1;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 23;
            this.lstJogadores.Location = new System.Drawing.Point(842, 252);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(361, 349);
            this.lstJogadores.TabIndex = 3;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // lblPartidaId
            // 
            this.lblPartidaId.AutoSize = true;
            this.lblPartidaId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaId.ForeColor = System.Drawing.Color.Black;
            this.lblPartidaId.Location = new System.Drawing.Point(520, 285);
            this.lblPartidaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartidaId.Name = "lblPartidaId";
            this.lblPartidaId.Size = new System.Drawing.Size(0, 41);
            this.lblPartidaId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(525, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "id partida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(525, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "nome:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomePartida.Location = new System.Drawing.Point(520, 417);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 41);
            this.lblNomePartida.TabIndex = 6;
            this.lblNomePartida.Click += new System.EventHandler(this.lblNomePartida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(525, 526);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "data:";
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartida.ForeColor = System.Drawing.Color.Black;
            this.lblDataPartida.Location = new System.Drawing.Point(520, 551);
            this.lblDataPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 41);
            this.lblDataPartida.TabIndex = 8;
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoJogo.ForeColor = System.Drawing.Color.Black;
            this.lblVersaoJogo.Location = new System.Drawing.Point(1260, 691);
            this.lblVersaoJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(70, 23);
            this.lblVersaoJogo.TabIndex = 10;
            this.lblVersaoJogo.Text = "V.Jogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNomeGrupo.Location = new System.Drawing.Point(1092, 693);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(161, 21);
            this.lblNomeGrupo.TabIndex = 12;
            this.lblNomeGrupo.Text = "Ferreiros de york";
            this.lblNomeGrupo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblJogadoresNaPartida
            // 
            this.lblJogadoresNaPartida.AutoSize = true;
            this.lblJogadoresNaPartida.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadoresNaPartida.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblJogadoresNaPartida.Location = new System.Drawing.Point(838, 218);
            this.lblJogadoresNaPartida.Name = "lblJogadoresNaPartida";
            this.lblJogadoresNaPartida.Size = new System.Drawing.Size(211, 19);
            this.lblJogadoresNaPartida.TabIndex = 13;
            this.lblJogadoresNaPartida.Text = "JOGADORES NA PARTIDA";
            this.lblJogadoresNaPartida.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(90, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "PARTIDAS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNomeCriarPartida
            // 
            this.txtNomeCriarPartida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCriarPartida.Location = new System.Drawing.Point(87, 132);
            this.txtNomeCriarPartida.Name = "txtNomeCriarPartida";
            this.txtNomeCriarPartida.Size = new System.Drawing.Size(277, 35);
            this.txtNomeCriarPartida.TabIndex = 15;
            // 
            // lblNomeCriarPartida
            // 
            this.lblNomeCriarPartida.AutoSize = true;
            this.lblNomeCriarPartida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCriarPartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCriarPartida.Location = new System.Drawing.Point(93, 99);
            this.lblNomeCriarPartida.Name = "lblNomeCriarPartida";
            this.lblNomeCriarPartida.Size = new System.Drawing.Size(83, 27);
            this.lblNomeCriarPartida.TabIndex = 16;
            this.lblNomeCriarPartida.Text = "NOME";
            // 
            // lblSenhaCriarPartida
            // 
            this.lblSenhaCriarPartida.AutoSize = true;
            this.lblSenhaCriarPartida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCriarPartida.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaCriarPartida.Location = new System.Drawing.Point(728, 99);
            this.lblSenhaCriarPartida.Name = "lblSenhaCriarPartida";
            this.lblSenhaCriarPartida.Size = new System.Drawing.Size(93, 27);
            this.lblSenhaCriarPartida.TabIndex = 18;
            this.lblSenhaCriarPartida.Text = "SENHA";
            // 
            // txtSenhaCriarPartida
            // 
            this.txtSenhaCriarPartida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCriarPartida.Location = new System.Drawing.Point(722, 132);
            this.txtSenhaCriarPartida.Name = "txtSenhaCriarPartida";
            this.txtSenhaCriarPartida.Size = new System.Drawing.Size(277, 35);
            this.txtSenhaCriarPartida.TabIndex = 17;
            // 
            // lblNomeGrupoCriarPartida
            // 
            this.lblNomeGrupoCriarPartida.AutoSize = true;
            this.lblNomeGrupoCriarPartida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupoCriarPartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomeGrupoCriarPartida.Location = new System.Drawing.Point(411, 99);
            this.lblNomeGrupoCriarPartida.Name = "lblNomeGrupoCriarPartida";
            this.lblNomeGrupoCriarPartida.Size = new System.Drawing.Size(221, 27);
            this.lblNomeGrupoCriarPartida.TabIndex = 20;
            this.lblNomeGrupoCriarPartida.Text = "NOME DO GRUPO";
            // 
            // txtNomeGrupoCriarPartida
            // 
            this.txtNomeGrupoCriarPartida.Enabled = false;
            this.txtNomeGrupoCriarPartida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGrupoCriarPartida.Location = new System.Drawing.Point(405, 132);
            this.txtNomeGrupoCriarPartida.Name = "txtNomeGrupoCriarPartida";
            this.txtNomeGrupoCriarPartida.Size = new System.Drawing.Size(277, 35);
            this.txtNomeGrupoCriarPartida.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(83, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 33);
            this.label10.TabIndex = 21;
            this.label10.Text = "Criar Partida";
            // 
            // bntCriarPartida
            // 
            this.bntCriarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bntCriarPartida.ForeColor = System.Drawing.Color.Black;
            this.bntCriarPartida.Location = new System.Drawing.Point(1032, 132);
            this.bntCriarPartida.Name = "bntCriarPartida";
            this.bntCriarPartida.Size = new System.Drawing.Size(81, 36);
            this.bntCriarPartida.TabIndex = 22;
            this.bntCriarPartida.Text = "Criar";
            this.bntCriarPartida.UseVisualStyleBackColor = false;
            this.bntCriarPartida.Click += new System.EventHandler(this.bntCriarPartida_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.bntCriarPartida);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNomeGrupoCriarPartida);
            this.Controls.Add(this.txtNomeGrupoCriarPartida);
            this.Controls.Add(this.lblSenhaCriarPartida);
            this.Controls.Add(this.txtSenhaCriarPartida);
            this.Controls.Add(this.lblNomeCriarPartida);
            this.Controls.Add(this.txtNomeCriarPartida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblJogadoresNaPartida);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDataPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartidaId);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartida);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelaInicial";
            this.Text = "Kinge Me";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartida;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblPartidaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.Label lblVersaoJogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblJogadoresNaPartida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeCriarPartida;
        private System.Windows.Forms.Label lblNomeCriarPartida;
        private System.Windows.Forms.Label lblSenhaCriarPartida;
        private System.Windows.Forms.TextBox txtSenhaCriarPartida;
        private System.Windows.Forms.Label lblNomeGrupoCriarPartida;
        private System.Windows.Forms.TextBox txtNomeGrupoCriarPartida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bntCriarPartida;
    }
}

