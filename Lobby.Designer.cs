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
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeJogadorPartida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdJogadorIdPartida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSenhaJogadorPartida = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJogadoresNaPartida
            // 
            this.lblJogadoresNaPartida.AutoSize = true;
            this.lblJogadoresNaPartida.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadoresNaPartida.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblJogadoresNaPartida.Location = new System.Drawing.Point(51, 295);
            this.lblJogadoresNaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadoresNaPartida.Name = "lblJogadoresNaPartida";
            this.lblJogadoresNaPartida.Size = new System.Drawing.Size(139, 14);
            this.lblJogadoresNaPartida.TabIndex = 15;
            this.lblJogadoresNaPartida.Text = "JOGADORES NA PARTIDA";
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 27;
            this.lstJogadores.Location = new System.Drawing.Point(53, 317);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(380, 112);
            this.lstJogadores.TabIndex = 14;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "nome partida:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomePartida.Location = new System.Drawing.Point(49, 147);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 27);
            this.lblNomePartida.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "id partida:";
            // 
            // lblPartidaId
            // 
            this.lblPartidaId.AutoSize = true;
            this.lblPartidaId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaId.ForeColor = System.Drawing.Color.Black;
            this.lblPartidaId.Location = new System.Drawing.Point(49, 61);
            this.lblPartidaId.Name = "lblPartidaId";
            this.lblPartidaId.Size = new System.Drawing.Size(0, 27);
            this.lblPartidaId.TabIndex = 16;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarPartida.Location = new System.Drawing.Point(54, 460);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(163, 58);
            this.btnIniciarPartida.TabIndex = 27;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnVoltarLobby
            // 
            this.btnVoltarLobby.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVoltarLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarLobby.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarLobby.Location = new System.Drawing.Point(264, 460);
            this.btnVoltarLobby.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarLobby.Name = "btnVoltarLobby";
            this.btnVoltarLobby.Size = new System.Drawing.Size(169, 58);
            this.btnVoltarLobby.TabIndex = 28;
            this.btnVoltarLobby.Text = "Voltar Lobby";
            this.btnVoltarLobby.UseVisualStyleBackColor = false;
            this.btnVoltarLobby.Click += new System.EventHandler(this.btnVoltarLobby_Click);
            // 
            // btnAtualizarJogadores
            // 
            this.btnAtualizarJogadores.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAtualizarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarJogadores.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizarJogadores.Location = new System.Drawing.Point(378, 328);
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
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "senha partida:";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaPartida.Location = new System.Drawing.Point(50, 231);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(0, 27);
            this.lblSenhaPartida.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(261, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Jogador (você)";
            // 
            // lblNomeJogadorPartida
            // 
            this.lblNomeJogadorPartida.AutoSize = true;
            this.lblNomeJogadorPartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogadorPartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomeJogadorPartida.Location = new System.Drawing.Point(260, 61);
            this.lblNomeJogadorPartida.Name = "lblNomeJogadorPartida";
            this.lblNomeJogadorPartida.Size = new System.Drawing.Size(0, 27);
            this.lblNomeJogadorPartida.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(262, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Jogador Id";
            // 
            // lblIdJogadorIdPartida
            // 
            this.lblIdJogadorIdPartida.AutoSize = true;
            this.lblIdJogadorIdPartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogadorIdPartida.ForeColor = System.Drawing.Color.Black;
            this.lblIdJogadorIdPartida.Location = new System.Drawing.Point(261, 147);
            this.lblIdJogadorIdPartida.Name = "lblIdJogadorIdPartida";
            this.lblIdJogadorIdPartida.Size = new System.Drawing.Size(0, 27);
            this.lblIdJogadorIdPartida.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(261, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Jogador Senha";
            // 
            // lblSenhaJogadorPartida
            // 
            this.lblSenhaJogadorPartida.AutoSize = true;
            this.lblSenhaJogadorPartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogadorPartida.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaJogadorPartida.Location = new System.Drawing.Point(260, 231);
            this.lblSenhaJogadorPartida.Name = "lblSenhaJogadorPartida";
            this.lblSenhaJogadorPartida.Size = new System.Drawing.Size(0, 27);
            this.lblSenhaJogadorPartida.TabIndex = 36;
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
            // TelaLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(479, 581);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSenhaJogadorPartida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIdJogadorIdPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNomeJogadorPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.btnAtualizarJogadores);
            this.Controls.Add(this.btnVoltarLobby);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartidaId);
            this.Controls.Add(this.lblJogadoresNaPartida);
            this.Controls.Add(this.lstJogadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomeJogadorPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIdJogadorIdPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSenhaJogadorPartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblVersaoJogo;
    }
}