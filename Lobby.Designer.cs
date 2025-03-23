namespace ferreirosDeYork
{
    partial class TelaLobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLobby));
            this.lblJogadoresNaPartida = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPartidaId = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnVoltarLobby = new System.Windows.Forms.Button();
            this.btnAtualizarJogadores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblNomeJogadorPartida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdJogadorIdPartida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSenhaJogadorPartida = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.lblPARTIDA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJogadoresNaPartida
            // 
            this.lblJogadoresNaPartida.AutoSize = true;
            this.lblJogadoresNaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadoresNaPartida.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadoresNaPartida.ForeColor = System.Drawing.Color.White;
            this.lblJogadoresNaPartida.Location = new System.Drawing.Point(675, 49);
            this.lblJogadoresNaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadoresNaPartida.Name = "lblJogadoresNaPartida";
            this.lblJogadoresNaPartida.Size = new System.Drawing.Size(290, 30);
            this.lblJogadoresNaPartida.TabIndex = 15;
            this.lblJogadoresNaPartida.Text = "JOGADORES NA PARTIDA";
            // 
            // lstJogadores
            // 
            this.lstJogadores.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstJogadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstJogadores.Font = new System.Drawing.Font("LCD5x8H", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.ForeColor = System.Drawing.Color.White;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 12;
            this.lstJogadores.Location = new System.Drawing.Point(83, 93);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(158, 146);
            this.lstJogadores.TabIndex = 14;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "SENHA:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePartida.Font = new System.Drawing.Font("LCD5x8H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.White;
            this.lblNomePartida.Image = ((System.Drawing.Image)(resources.GetObject("lblNomePartida.Image")));
            this.lblNomePartida.Location = new System.Drawing.Point(153, 137);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(237, 27);
            this.lblNomePartida.TabIndex = 18;
            this.lblNomePartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // lblPartidaId
            // 
            this.lblPartidaId.BackColor = System.Drawing.Color.Transparent;
            this.lblPartidaId.Font = new System.Drawing.Font("LCD5x8H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaId.ForeColor = System.Drawing.Color.White;
            this.lblPartidaId.Image = ((System.Drawing.Image)(resources.GetObject("lblPartidaId.Image")));
            this.lblPartidaId.Location = new System.Drawing.Point(150, 103);
            this.lblPartidaId.Name = "lblPartidaId";
            this.lblPartidaId.Size = new System.Drawing.Size(242, 28);
            this.lblPartidaId.TabIndex = 16;
            this.lblPartidaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPartidaId.Click += new System.EventHandler(this.lblPartidaId_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.FlatAppearance.BorderSize = 0;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarPartida.Image")));
            this.btnIniciarPartida.Location = new System.Drawing.Point(443, 379);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(146, 133);
            this.btnIniciarPartida.TabIndex = 27;
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnVoltarLobby
            // 
            this.btnVoltarLobby.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarLobby.FlatAppearance.BorderSize = 0;
            this.btnVoltarLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarLobby.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarLobby.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarLobby.Image")));
            this.btnVoltarLobby.Location = new System.Drawing.Point(63, 406);
            this.btnVoltarLobby.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarLobby.Name = "btnVoltarLobby";
            this.btnVoltarLobby.Size = new System.Drawing.Size(81, 79);
            this.btnVoltarLobby.TabIndex = 28;
            this.btnVoltarLobby.UseVisualStyleBackColor = false;
            this.btnVoltarLobby.Click += new System.EventHandler(this.btnVoltarLobby_Click);
            // 
            // btnAtualizarJogadores
            // 
            this.btnAtualizarJogadores.BackColor = System.Drawing.Color.Black;
            this.btnAtualizarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarJogadores.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarJogadores.Location = new System.Drawing.Point(143, 256);
            this.btnAtualizarJogadores.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizarJogadores.Name = "btnAtualizarJogadores";
            this.btnAtualizarJogadores.Size = new System.Drawing.Size(44, 38);
            this.btnAtualizarJogadores.TabIndex = 29;
            this.btnAtualizarJogadores.Text = "🔄";
            this.btnAtualizarJogadores.UseVisualStyleBackColor = false;
            this.btnAtualizarJogadores.Click += new System.EventHandler(this.btnAtualizarJogadores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "NOME:";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaPartida.Font = new System.Drawing.Font("LCD5x8H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.ForeColor = System.Drawing.Color.White;
            this.lblSenhaPartida.Image = ((System.Drawing.Image)(resources.GetObject("lblSenhaPartida.Image")));
            this.lblSenhaPartida.Location = new System.Drawing.Point(153, 170);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(239, 27);
            this.lblSenhaPartida.TabIndex = 30;
            this.lblSenhaPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeJogadorPartida
            // 
            this.lblNomeJogadorPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogadorPartida.Font = new System.Drawing.Font("LCD5x8H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogadorPartida.ForeColor = System.Drawing.Color.White;
            this.lblNomeJogadorPartida.Image = ((System.Drawing.Image)(resources.GetObject("lblNomeJogadorPartida.Image")));
            this.lblNomeJogadorPartida.Location = new System.Drawing.Point(156, 336);
            this.lblNomeJogadorPartida.Name = "lblNomeJogadorPartida";
            this.lblNomeJogadorPartida.Size = new System.Drawing.Size(239, 27);
            this.lblNomeJogadorPartida.TabIndex = 32;
            this.lblNomeJogadorPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(57, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID:";
            // 
            // lblIdJogadorIdPartida
            // 
            this.lblIdJogadorIdPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblIdJogadorIdPartida.Font = new System.Drawing.Font("LCD5x8H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogadorIdPartida.ForeColor = System.Drawing.Color.White;
            this.lblIdJogadorIdPartida.Image = ((System.Drawing.Image)(resources.GetObject("lblIdJogadorIdPartida.Image")));
            this.lblIdJogadorIdPartida.Location = new System.Drawing.Point(156, 303);
            this.lblIdJogadorIdPartida.Name = "lblIdJogadorIdPartida";
            this.lblIdJogadorIdPartida.Size = new System.Drawing.Size(238, 27);
            this.lblIdJogadorIdPartida.TabIndex = 34;
            this.lblIdJogadorIdPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 33);
            this.label6.TabIndex = 37;
            this.label6.Text = "SENHA:";
            // 
            // lblSenhaJogadorPartida
            // 
            this.lblSenhaJogadorPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaJogadorPartida.Font = new System.Drawing.Font("LCD5x8H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogadorPartida.ForeColor = System.Drawing.Color.White;
            this.lblSenhaJogadorPartida.Image = ((System.Drawing.Image)(resources.GetObject("lblSenhaJogadorPartida.Image")));
            this.lblSenhaJogadorPartida.Location = new System.Drawing.Point(153, 369);
            this.lblSenhaJogadorPartida.Name = "lblSenhaJogadorPartida";
            this.lblSenhaJogadorPartida.Size = new System.Drawing.Size(245, 27);
            this.lblSenhaJogadorPartida.TabIndex = 36;
            this.lblSenhaJogadorPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.ForeColor = System.Drawing.Color.White;
            this.lblNomeGrupo.Location = new System.Drawing.Point(275, 545);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(104, 15);
            this.lblNomeGrupo.TabIndex = 39;
            this.lblNomeGrupo.Text = "Ferreiros de york";
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoJogo.ForeColor = System.Drawing.Color.Black;
            this.lblVersaoJogo.Location = new System.Drawing.Point(387, 544);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(46, 16);
            this.lblVersaoJogo.TabIndex = 38;
            this.lblVersaoJogo.Text = "V.Jogo";
            // 
            // lblPARTIDA
            // 
            this.lblPARTIDA.AutoSize = true;
            this.lblPARTIDA.BackColor = System.Drawing.Color.Transparent;
            this.lblPARTIDA.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPARTIDA.ForeColor = System.Drawing.Color.White;
            this.lblPARTIDA.Location = new System.Drawing.Point(49, 18);
            this.lblPARTIDA.Name = "lblPARTIDA";
            this.lblPARTIDA.Size = new System.Drawing.Size(309, 79);
            this.lblPARTIDA.TabIndex = 40;
            this.lblPARTIDA.Text = "PARTIDA";
            this.lblPARTIDA.Click += new System.EventHandler(this.lblPARTIDA_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(49, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 79);
            this.label7.TabIndex = 41;
            this.label7.Text = "JOGADOR";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 33);
            this.label4.TabIndex = 42;
            this.label4.Text = "NOME:";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lstJogadores);
            this.panel1.Controls.Add(this.btnAtualizarJogadores);
            this.panel1.Location = new System.Drawing.Point(652, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 348);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TelaLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPartidaId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPARTIDA);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSenhaJogadorPartida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIdJogadorIdPartida);
            this.Controls.Add(this.lblNomeJogadorPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.btnVoltarLobby);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJogadoresNaPartida);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.TelaLobby_Load_1);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJogadoresNaPartida;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPartidaId;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnVoltarLobby;
        private System.Windows.Forms.Button btnAtualizarJogadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblNomeJogadorPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIdJogadorIdPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSenhaJogadorPartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblVersaoJogo;
        private System.Windows.Forms.Label lblPARTIDA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}