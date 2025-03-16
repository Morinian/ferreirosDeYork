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
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarPartida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarPartida.Location = new System.Drawing.Point(60, 449);
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
            this.lstPartidas.Location = new System.Drawing.Point(59, 203);
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
            this.lstJogadores.Location = new System.Drawing.Point(558, 203);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(242, 228);
            this.lstJogadores.TabIndex = 3;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // lblPartidaId
            // 
            this.lblPartidaId.AutoSize = true;
            this.lblPartidaId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaId.ForeColor = System.Drawing.Color.Black;
            this.lblPartidaId.Location = new System.Drawing.Point(344, 224);
            this.lblPartidaId.Name = "lblPartidaId";
            this.lblPartidaId.Size = new System.Drawing.Size(0, 27);
            this.lblPartidaId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "id partida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "nome:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.Black;
            this.lblNomePartida.Location = new System.Drawing.Point(344, 310);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 27);
            this.lblNomePartida.TabIndex = 6;
            this.lblNomePartida.Click += new System.EventHandler(this.lblNomePartida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(347, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "data:";
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartida.ForeColor = System.Drawing.Color.Black;
            this.lblDataPartida.Location = new System.Drawing.Point(344, 397);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 27);
            this.lblDataPartida.TabIndex = 8;
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblVersaoJogo.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoJogo.ForeColor = System.Drawing.Color.White;
            this.lblVersaoJogo.Location = new System.Drawing.Point(931, 481);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(45, 14);
            this.lblVersaoJogo.TabIndex = 10;
            this.lblVersaoJogo.Text = "V.Jogo";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.ForeColor = System.Drawing.Color.White;
            this.lblNomeGrupo.Location = new System.Drawing.Point(819, 482);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(116, 14);
            this.lblNomeGrupo.TabIndex = 12;
            this.lblNomeGrupo.Text = "Ferreiros de york";
            this.lblNomeGrupo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblJogadoresNaPartida
            // 
            this.lblJogadoresNaPartida.AutoSize = true;
            this.lblJogadoresNaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadoresNaPartida.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadoresNaPartida.ForeColor = System.Drawing.Color.White;
            this.lblJogadoresNaPartida.Location = new System.Drawing.Point(556, 181);
            this.lblJogadoresNaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadoresNaPartida.Name = "lblJogadoresNaPartida";
            this.lblJogadoresNaPartida.Size = new System.Drawing.Size(138, 14);
            this.lblJogadoresNaPartida.TabIndex = 13;
            this.lblJogadoresNaPartida.Text = "JOGADORES NA PARTIDA";
            this.lblJogadoresNaPartida.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(57, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "PARTIDAS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNomeCriarPartida
            // 
            this.txtNomeCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.txtNomeCriarPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCriarPartida.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.txtNomeCriarPartida.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNomeCriarPartida.Location = new System.Drawing.Point(34, 15);
            this.txtNomeCriarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCriarPartida.Multiline = true;
            this.txtNomeCriarPartida.Name = "txtNomeCriarPartida";
            this.txtNomeCriarPartida.Size = new System.Drawing.Size(202, 40);
            this.txtNomeCriarPartida.TabIndex = 15;
            this.txtNomeCriarPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeCriarPartida
            // 
            this.lblNomeCriarPartida.AutoSize = true;
            this.lblNomeCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCriarPartida.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCriarPartida.ForeColor = System.Drawing.Color.White;
            this.lblNomeCriarPartida.Location = new System.Drawing.Point(62, 64);
            this.lblNomeCriarPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCriarPartida.Name = "lblNomeCriarPartida";
            this.lblNomeCriarPartida.Size = new System.Drawing.Size(38, 14);
            this.lblNomeCriarPartida.TabIndex = 16;
            this.lblNomeCriarPartida.Text = "NOME";
            // 
            // lblSenhaCriarPartida
            // 
            this.lblSenhaCriarPartida.AutoSize = true;
            this.lblSenhaCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaCriarPartida.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCriarPartida.ForeColor = System.Drawing.Color.White;
            this.lblSenhaCriarPartida.Location = new System.Drawing.Point(516, 64);
            this.lblSenhaCriarPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaCriarPartida.Name = "lblSenhaCriarPartida";
            this.lblSenhaCriarPartida.Size = new System.Drawing.Size(43, 14);
            this.lblSenhaCriarPartida.TabIndex = 18;
            this.lblSenhaCriarPartida.Text = "SENHA";
            // 
            // txtSenhaCriarPartida
            // 
            this.txtSenhaCriarPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.txtSenhaCriarPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaCriarPartida.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.txtSenhaCriarPartida.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSenhaCriarPartida.Location = new System.Drawing.Point(34, 15);
            this.txtSenhaCriarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaCriarPartida.Multiline = true;
            this.txtSenhaCriarPartida.Name = "txtSenhaCriarPartida";
            this.txtSenhaCriarPartida.ReadOnly = true;
            this.txtSenhaCriarPartida.Size = new System.Drawing.Size(202, 40);
            this.txtSenhaCriarPartida.TabIndex = 17;
            // 
            // lblNomeGrupoCriarPartida
            // 
            this.lblNomeGrupoCriarPartida.AutoSize = true;
            this.lblNomeGrupoCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeGrupoCriarPartida.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupoCriarPartida.ForeColor = System.Drawing.Color.White;
            this.lblNomeGrupoCriarPartida.Location = new System.Drawing.Point(286, 64);
            this.lblNomeGrupoCriarPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeGrupoCriarPartida.Name = "lblNomeGrupoCriarPartida";
            this.lblNomeGrupoCriarPartida.Size = new System.Drawing.Size(97, 14);
            this.lblNomeGrupoCriarPartida.TabIndex = 20;
            this.lblNomeGrupoCriarPartida.Text = "NOME DO GRUPO";
            // 
            // txtNomeGrupoCriarPartida
            // 
            this.txtNomeGrupoCriarPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeGrupoCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.txtNomeGrupoCriarPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeGrupoCriarPartida.Enabled = false;
            this.txtNomeGrupoCriarPartida.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.txtNomeGrupoCriarPartida.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNomeGrupoCriarPartida.Location = new System.Drawing.Point(34, 15);
            this.txtNomeGrupoCriarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeGrupoCriarPartida.Multiline = true;
            this.txtNomeGrupoCriarPartida.Name = "txtNomeGrupoCriarPartida";
            this.txtNomeGrupoCriarPartida.ReadOnly = true;
            this.txtNomeGrupoCriarPartida.Size = new System.Drawing.Size(202, 40);
            this.txtNomeGrupoCriarPartida.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(55, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Criar Partida";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnCriarPartida.Location = new System.Drawing.Point(898, 86);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(81, 26);
            this.btnCriarPartida.TabIndex = 22;
            this.btnCriarPartida.Text = "Criar";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Entrar na partida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(824, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nome Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(827, 226);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(152, 26);
            this.txtNomeJogador.TabIndex = 24;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnEntrarPartida.Location = new System.Drawing.Point(827, 349);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(152, 58);
            this.btnEntrarPartida.TabIndex = 26;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(349, 449);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 48);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(824, 268);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "Senha Partida";
            // 
            // txtSenhaEntrarPartida
            // 
            this.txtSenhaEntrarPartida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEntrarPartida.Location = new System.Drawing.Point(827, 294);
            this.txtSenhaEntrarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaEntrarPartida.Name = "txtSenhaEntrarPartida";
            this.txtSenhaEntrarPartida.Size = new System.Drawing.Size(152, 26);
            this.txtSenhaEntrarPartida.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txtNomeCriarPartida);
            this.panel1.Location = new System.Drawing.Point(26, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 69);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.txtNomeGrupoCriarPartida);
            this.panel2.Location = new System.Drawing.Point(620, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 69);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.txtSenhaCriarPartida);
            this.panel3.Location = new System.Drawing.Point(319, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 69);
            this.panel3.TabIndex = 32;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 534);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSenhaEntrarPartida);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNomeGrupoCriarPartida);
            this.Controls.Add(this.lblSenhaCriarPartida);
            this.Controls.Add(this.lblNomeCriarPartida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblJogadoresNaPartida);
            this.Controls.Add(this.lblNomeGrupo);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "King Me";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenhaEntrarPartida;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

