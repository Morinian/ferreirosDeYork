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
            this.lblJogadoresNaPartida = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPartidaId = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnVoltarLobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJogadoresNaPartida
            // 
            this.lblJogadoresNaPartida.AutoSize = true;
            this.lblJogadoresNaPartida.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadoresNaPartida.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblJogadoresNaPartida.Location = new System.Drawing.Point(51, 229);
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
            this.lstJogadores.Location = new System.Drawing.Point(53, 251);
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
            this.label2.Location = new System.Drawing.Point(51, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "nome:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomePartida.Location = new System.Drawing.Point(48, 163);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 27);
            this.lblNomePartida.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 61);
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
            this.lblPartidaId.Location = new System.Drawing.Point(48, 77);
            this.lblPartidaId.Name = "lblPartidaId";
            this.lblPartidaId.Size = new System.Drawing.Size(0, 27);
            this.lblPartidaId.TabIndex = 16;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarPartida.Location = new System.Drawing.Point(54, 394);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(163, 58);
            this.btnIniciarPartida.TabIndex = 27;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            // 
            // btnVoltarLobby
            // 
            this.btnVoltarLobby.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVoltarLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarLobby.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarLobby.Location = new System.Drawing.Point(264, 394);
            this.btnVoltarLobby.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarLobby.Name = "btnVoltarLobby";
            this.btnVoltarLobby.Size = new System.Drawing.Size(169, 58);
            this.btnVoltarLobby.TabIndex = 28;
            this.btnVoltarLobby.Text = "Voltar Lobby";
            this.btnVoltarLobby.UseVisualStyleBackColor = false;
            this.btnVoltarLobby.Click += new System.EventHandler(this.btnVoltarLobby_Click);
            // 
            // TelaLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 480);
            this.Controls.Add(this.btnVoltarLobby);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartidaId);
            this.Controls.Add(this.lblJogadoresNaPartida);
            this.Controls.Add(this.lstJogadores);
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
    }
}