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
            this.SuspendLayout();
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarPartida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarPartida.Location = new System.Drawing.Point(62, 56);
            this.btnListarPartida.Name = "btnListarPartida";
            this.btnListarPartida.Size = new System.Drawing.Size(254, 48);
            this.btnListarPartida.TabIndex = 0;
            this.btnListarPartida.Text = "Listar Partidas";
            this.btnListarPartida.UseVisualStyleBackColor = false;
            this.btnListarPartida.Click += new System.EventHandler(this.btnListarPartida_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(62, 164);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(254, 228);
            this.lstPartidas.TabIndex = 1;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(561, 164);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(242, 228);
            this.lstJogadores.TabIndex = 3;
            // 
            // lblPartidaId
            // 
            this.lblPartidaId.AutoSize = true;
            this.lblPartidaId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaId.ForeColor = System.Drawing.Color.Black;
            this.lblPartidaId.Location = new System.Drawing.Point(347, 185);
            this.lblPartidaId.Name = "lblPartidaId";
            this.lblPartidaId.Size = new System.Drawing.Size(77, 27);
            this.lblPartidaId.TabIndex = 4;
            this.lblPartidaId.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(350, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "id partida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(350, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "nome:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomePartida.Location = new System.Drawing.Point(347, 271);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(77, 27);
            this.lblNomePartida.TabIndex = 6;
            this.lblNomePartida.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(350, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "data:";
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartida.ForeColor = System.Drawing.Color.Black;
            this.lblDataPartida.Location = new System.Drawing.Point(347, 358);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(77, 27);
            this.lblDataPartida.TabIndex = 8;
            this.lblDataPartida.Text = "label1";
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoJogo.ForeColor = System.Drawing.Color.Black;
            this.lblVersaoJogo.Location = new System.Drawing.Point(840, 449);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(46, 16);
            this.lblVersaoJogo.TabIndex = 10;
            this.lblVersaoJogo.Text = "V.Jogo";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(898, 474);
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
            this.Name = "TelaInicial";
            this.Text = "Kinge Me";
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
    }
}

