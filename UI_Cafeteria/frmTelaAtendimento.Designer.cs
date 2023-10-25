
namespace UI_Atendimento
{
    partial class frmTelaAtendimento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaAtendimento));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnSalgados = new System.Windows.Forms.Button();
            this.btnSobremesas = new System.Windows.Forms.Button();
            this.dgvResumo = new System.Windows.Forms.DataGridView();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PdMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipBotao = new System.Windows.Forms.ToolTip(this.components);
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.btnAcai = new System.Windows.Forms.Button();
            this.btnBrownie = new System.Windows.Forms.Button();
            this.btnBoloInteiro = new System.Windows.Forms.Button();
            this.btnBoloIndividual = new System.Windows.Forms.Button();
            this.btnPaoChapa = new System.Windows.Forms.Button();
            this.btnMistoQuente = new System.Windows.Forms.Button();
            this.btnEmpadinha = new System.Windows.Forms.Button();
            this.btnFrango = new System.Windows.Forms.Button();
            this.btnBatata = new System.Windows.Forms.Button();
            this.btnRefrigerante = new System.Windows.Forms.Button();
            this.btnAgua = new System.Windows.Forms.Button();
            this.btnCappuccino = new System.Windows.Forms.Button();
            this.btnAchocolatado = new System.Windows.Forms.Button();
            this.btnCafeLeite = new System.Windows.Forms.Button();
            this.btnCoado = new System.Windows.Forms.Button();
            this.btnExpresso = new System.Windows.Forms.Button();
            this.grpBebidas = new System.Windows.Forms.GroupBox();
            this.grpSalgados = new System.Windows.Forms.GroupBox();
            this.grpSobremesas = new System.Windows.Forms.GroupBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblMesa = new System.Windows.Forms.Label();
            this.cboMesa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumo)).BeginInit();
            this.grpCategorias.SuspendLayout();
            this.grpBebidas.SuspendLayout();
            this.grpSalgados.SuspendLayout();
            this.grpSobremesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(115, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 18);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNome.Location = new System.Drawing.Point(179, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(255, 24);
            this.txtNome.TabIndex = 1;
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackColor = System.Drawing.Color.Transparent;
            this.btnBebidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBebidas.BackgroundImage")));
            this.btnBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBebidas.FlatAppearance.BorderSize = 0;
            this.btnBebidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBebidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBebidas.Location = new System.Drawing.Point(21, 20);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(125, 110);
            this.btnBebidas.TabIndex = 3;
            this.btnBebidas.UseVisualStyleBackColor = false;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnSalgados
            // 
            this.btnSalgados.BackColor = System.Drawing.Color.Transparent;
            this.btnSalgados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalgados.BackgroundImage")));
            this.btnSalgados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalgados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalgados.FlatAppearance.BorderSize = 0;
            this.btnSalgados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalgados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalgados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalgados.Location = new System.Drawing.Point(191, 19);
            this.btnSalgados.Name = "btnSalgados";
            this.btnSalgados.Size = new System.Drawing.Size(125, 110);
            this.btnSalgados.TabIndex = 4;
            this.btnSalgados.UseVisualStyleBackColor = false;
            this.btnSalgados.Click += new System.EventHandler(this.btnSalgados_Click);
            // 
            // btnSobremesas
            // 
            this.btnSobremesas.BackColor = System.Drawing.Color.Transparent;
            this.btnSobremesas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSobremesas.BackgroundImage")));
            this.btnSobremesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSobremesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobremesas.FlatAppearance.BorderSize = 0;
            this.btnSobremesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSobremesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSobremesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobremesas.ForeColor = System.Drawing.Color.Black;
            this.btnSobremesas.Location = new System.Drawing.Point(354, 20);
            this.btnSobremesas.Name = "btnSobremesas";
            this.btnSobremesas.Size = new System.Drawing.Size(125, 110);
            this.btnSobremesas.TabIndex = 5;
            this.btnSobremesas.UseVisualStyleBackColor = false;
            this.btnSobremesas.Click += new System.EventHandler(this.btnSobremesas_Click);
            // 
            // dgvResumo
            // 
            this.dgvResumo.AllowUserToAddRows = false;
            this.dgvResumo.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qtde,
            this.Descricao,
            this.Unitario,
            this.PdMesa,
            this.PdCliente});
            this.dgvResumo.Location = new System.Drawing.Point(631, 112);
            this.dgvResumo.Name = "dgvResumo";
            this.dgvResumo.Size = new System.Drawing.Size(371, 420);
            this.dgvResumo.TabIndex = 11;
            this.dgvResumo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumo_CellClick);
            this.dgvResumo.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvResumo_RowsRemoved);
            // 
            // Qtde
            // 
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.Width = 35;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Unitario
            // 
            this.Unitario.HeaderText = "Unitario R$";
            this.Unitario.Name = "Unitario";
            this.Unitario.Width = 83;
            // 
            // PdMesa
            // 
            this.PdMesa.HeaderText = "Mesa";
            this.PdMesa.Name = "PdMesa";
            this.PdMesa.Width = 35;
            // 
            // PdCliente
            // 
            this.PdCliente.HeaderText = "Cliente";
            this.PdCliente.Name = "PdCliente";
            this.PdCliente.Width = 75;
            // 
            // grpCategorias
            // 
            this.grpCategorias.BackColor = System.Drawing.Color.Transparent;
            this.grpCategorias.Controls.Add(this.btnBebidas);
            this.grpCategorias.Controls.Add(this.btnSalgados);
            this.grpCategorias.Controls.Add(this.btnSobremesas);
            this.grpCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategorias.ForeColor = System.Drawing.Color.White;
            this.grpCategorias.Location = new System.Drawing.Point(118, 104);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Size = new System.Drawing.Size(507, 150);
            this.grpCategorias.TabIndex = 12;
            this.grpCategorias.TabStop = false;
            this.grpCategorias.Text = "Categorias";
            // 
            // btnAcai
            // 
            this.btnAcai.BackColor = System.Drawing.Color.White;
            this.btnAcai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcai.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcai.ForeColor = System.Drawing.Color.Black;
            this.btnAcai.Location = new System.Drawing.Point(15, 127);
            this.btnAcai.Name = "btnAcai";
            this.btnAcai.Size = new System.Drawing.Size(147, 30);
            this.btnAcai.TabIndex = 15;
            this.btnAcai.Text = "Açaí";
            this.btnAcai.UseVisualStyleBackColor = false;
            this.btnAcai.Click += new System.EventHandler(this.btnAcai_Click);
            // 
            // btnBrownie
            // 
            this.btnBrownie.BackColor = System.Drawing.Color.White;
            this.btnBrownie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrownie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrownie.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrownie.ForeColor = System.Drawing.Color.Black;
            this.btnBrownie.Location = new System.Drawing.Point(15, 91);
            this.btnBrownie.Name = "btnBrownie";
            this.btnBrownie.Size = new System.Drawing.Size(147, 30);
            this.btnBrownie.TabIndex = 14;
            this.btnBrownie.Text = "Brownie com Sorvete";
            this.btnBrownie.UseVisualStyleBackColor = false;
            this.btnBrownie.Click += new System.EventHandler(this.btnBrownie_Click);
            // 
            // btnBoloInteiro
            // 
            this.btnBoloInteiro.BackColor = System.Drawing.Color.White;
            this.btnBoloInteiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoloInteiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoloInteiro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoloInteiro.ForeColor = System.Drawing.Color.Black;
            this.btnBoloInteiro.Location = new System.Drawing.Point(15, 55);
            this.btnBoloInteiro.Name = "btnBoloInteiro";
            this.btnBoloInteiro.Size = new System.Drawing.Size(147, 30);
            this.btnBoloInteiro.TabIndex = 13;
            this.btnBoloInteiro.Text = "Bolo Inteiro";
            this.btnBoloInteiro.UseVisualStyleBackColor = false;
            this.btnBoloInteiro.Click += new System.EventHandler(this.btnBoloInteiro_Click);
            // 
            // btnBoloIndividual
            // 
            this.btnBoloIndividual.BackColor = System.Drawing.Color.White;
            this.btnBoloIndividual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoloIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoloIndividual.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoloIndividual.ForeColor = System.Drawing.Color.Black;
            this.btnBoloIndividual.Location = new System.Drawing.Point(15, 19);
            this.btnBoloIndividual.Name = "btnBoloIndividual";
            this.btnBoloIndividual.Size = new System.Drawing.Size(147, 30);
            this.btnBoloIndividual.TabIndex = 12;
            this.btnBoloIndividual.Text = "Bolo Individual";
            this.btnBoloIndividual.UseVisualStyleBackColor = false;
            this.btnBoloIndividual.Visible = false;
            this.btnBoloIndividual.Click += new System.EventHandler(this.btnBoloIndividual_Click);
            // 
            // btnPaoChapa
            // 
            this.btnPaoChapa.BackColor = System.Drawing.Color.White;
            this.btnPaoChapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaoChapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaoChapa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaoChapa.ForeColor = System.Drawing.Color.Black;
            this.btnPaoChapa.Location = new System.Drawing.Point(19, 163);
            this.btnPaoChapa.Name = "btnPaoChapa";
            this.btnPaoChapa.Size = new System.Drawing.Size(131, 30);
            this.btnPaoChapa.TabIndex = 11;
            this.btnPaoChapa.Text = "Pão na Chapa";
            this.btnPaoChapa.UseVisualStyleBackColor = false;
            this.btnPaoChapa.Click += new System.EventHandler(this.btnPaoChapa_Click);
            // 
            // btnMistoQuente
            // 
            this.btnMistoQuente.BackColor = System.Drawing.Color.White;
            this.btnMistoQuente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMistoQuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMistoQuente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMistoQuente.ForeColor = System.Drawing.Color.Black;
            this.btnMistoQuente.Location = new System.Drawing.Point(19, 127);
            this.btnMistoQuente.Name = "btnMistoQuente";
            this.btnMistoQuente.Size = new System.Drawing.Size(131, 30);
            this.btnMistoQuente.TabIndex = 10;
            this.btnMistoQuente.Text = "Misto Quente";
            this.btnMistoQuente.UseVisualStyleBackColor = false;
            this.btnMistoQuente.Click += new System.EventHandler(this.btnMistoQuente_Click);
            // 
            // btnEmpadinha
            // 
            this.btnEmpadinha.BackColor = System.Drawing.Color.White;
            this.btnEmpadinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpadinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpadinha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpadinha.ForeColor = System.Drawing.Color.Black;
            this.btnEmpadinha.Location = new System.Drawing.Point(19, 91);
            this.btnEmpadinha.Name = "btnEmpadinha";
            this.btnEmpadinha.Size = new System.Drawing.Size(131, 30);
            this.btnEmpadinha.TabIndex = 9;
            this.btnEmpadinha.Text = "Empadinha";
            this.btnEmpadinha.UseVisualStyleBackColor = false;
            this.btnEmpadinha.Click += new System.EventHandler(this.btnEmpadinha_Click);
            // 
            // btnFrango
            // 
            this.btnFrango.BackColor = System.Drawing.Color.White;
            this.btnFrango.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrango.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrango.ForeColor = System.Drawing.Color.Black;
            this.btnFrango.Location = new System.Drawing.Point(19, 55);
            this.btnFrango.Name = "btnFrango";
            this.btnFrango.Size = new System.Drawing.Size(131, 30);
            this.btnFrango.TabIndex = 8;
            this.btnFrango.Text = "Frango Creme";
            this.btnFrango.UseVisualStyleBackColor = false;
            this.btnFrango.Click += new System.EventHandler(this.btnFrango_Click);
            // 
            // btnBatata
            // 
            this.btnBatata.BackColor = System.Drawing.Color.White;
            this.btnBatata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatata.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatata.ForeColor = System.Drawing.Color.Black;
            this.btnBatata.Location = new System.Drawing.Point(19, 19);
            this.btnBatata.Name = "btnBatata";
            this.btnBatata.Size = new System.Drawing.Size(131, 30);
            this.btnBatata.TabIndex = 7;
            this.btnBatata.Text = "Batata Recheada";
            this.btnBatata.UseVisualStyleBackColor = false;
            this.btnBatata.Visible = false;
            this.btnBatata.Click += new System.EventHandler(this.btnBatata_Click);
            // 
            // btnRefrigerante
            // 
            this.btnRefrigerante.BackColor = System.Drawing.Color.White;
            this.btnRefrigerante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrigerante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrigerante.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrigerante.ForeColor = System.Drawing.Color.Black;
            this.btnRefrigerante.Location = new System.Drawing.Point(21, 234);
            this.btnRefrigerante.Name = "btnRefrigerante";
            this.btnRefrigerante.Size = new System.Drawing.Size(131, 30);
            this.btnRefrigerante.TabIndex = 6;
            this.btnRefrigerante.Text = "Refrigerante";
            this.btnRefrigerante.UseVisualStyleBackColor = false;
            this.btnRefrigerante.Click += new System.EventHandler(this.btnRefrigerante_Click);
            // 
            // btnAgua
            // 
            this.btnAgua.BackColor = System.Drawing.Color.White;
            this.btnAgua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgua.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgua.ForeColor = System.Drawing.Color.Black;
            this.btnAgua.Location = new System.Drawing.Point(21, 198);
            this.btnAgua.Name = "btnAgua";
            this.btnAgua.Size = new System.Drawing.Size(131, 30);
            this.btnAgua.TabIndex = 5;
            this.btnAgua.Text = "Água";
            this.btnAgua.UseVisualStyleBackColor = false;
            this.btnAgua.Click += new System.EventHandler(this.btnAgua_Click);
            // 
            // btnCappuccino
            // 
            this.btnCappuccino.BackColor = System.Drawing.Color.White;
            this.btnCappuccino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCappuccino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCappuccino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCappuccino.ForeColor = System.Drawing.Color.Black;
            this.btnCappuccino.Location = new System.Drawing.Point(21, 162);
            this.btnCappuccino.Name = "btnCappuccino";
            this.btnCappuccino.Size = new System.Drawing.Size(131, 30);
            this.btnCappuccino.TabIndex = 4;
            this.btnCappuccino.Text = "Cappuccino";
            this.btnCappuccino.UseVisualStyleBackColor = false;
            this.btnCappuccino.Click += new System.EventHandler(this.btnCappuccino_Click);
            // 
            // btnAchocolatado
            // 
            this.btnAchocolatado.BackColor = System.Drawing.Color.White;
            this.btnAchocolatado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAchocolatado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchocolatado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchocolatado.ForeColor = System.Drawing.Color.Black;
            this.btnAchocolatado.Location = new System.Drawing.Point(21, 126);
            this.btnAchocolatado.Name = "btnAchocolatado";
            this.btnAchocolatado.Size = new System.Drawing.Size(131, 30);
            this.btnAchocolatado.TabIndex = 3;
            this.btnAchocolatado.Text = "Achocolatado";
            this.btnAchocolatado.UseVisualStyleBackColor = false;
            this.btnAchocolatado.Click += new System.EventHandler(this.btnAchocolatado_Click);
            // 
            // btnCafeLeite
            // 
            this.btnCafeLeite.BackColor = System.Drawing.Color.White;
            this.btnCafeLeite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCafeLeite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCafeLeite.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafeLeite.ForeColor = System.Drawing.Color.Black;
            this.btnCafeLeite.Location = new System.Drawing.Point(21, 90);
            this.btnCafeLeite.Name = "btnCafeLeite";
            this.btnCafeLeite.Size = new System.Drawing.Size(131, 30);
            this.btnCafeLeite.TabIndex = 2;
            this.btnCafeLeite.Text = "Café com Leite";
            this.btnCafeLeite.UseVisualStyleBackColor = false;
            this.btnCafeLeite.Click += new System.EventHandler(this.btnCafeLeite_Click);
            // 
            // btnCoado
            // 
            this.btnCoado.BackColor = System.Drawing.Color.White;
            this.btnCoado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoado.ForeColor = System.Drawing.Color.Black;
            this.btnCoado.Location = new System.Drawing.Point(21, 54);
            this.btnCoado.Name = "btnCoado";
            this.btnCoado.Size = new System.Drawing.Size(131, 30);
            this.btnCoado.TabIndex = 1;
            this.btnCoado.Text = "Café Coado";
            this.btnCoado.UseVisualStyleBackColor = false;
            this.btnCoado.Visible = false;
            this.btnCoado.Click += new System.EventHandler(this.btnCoado_Click);
            // 
            // btnExpresso
            // 
            this.btnExpresso.BackColor = System.Drawing.Color.White;
            this.btnExpresso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpresso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpresso.ForeColor = System.Drawing.Color.Black;
            this.btnExpresso.Location = new System.Drawing.Point(21, 18);
            this.btnExpresso.Name = "btnExpresso";
            this.btnExpresso.Size = new System.Drawing.Size(131, 30);
            this.btnExpresso.TabIndex = 0;
            this.btnExpresso.Text = "Café Expresso";
            this.btnExpresso.UseVisualStyleBackColor = false;
            this.btnExpresso.Visible = false;
            this.btnExpresso.Click += new System.EventHandler(this.btnExpresso_Click);
            // 
            // grpBebidas
            // 
            this.grpBebidas.BackColor = System.Drawing.Color.Transparent;
            this.grpBebidas.Controls.Add(this.btnAgua);
            this.grpBebidas.Controls.Add(this.btnCappuccino);
            this.grpBebidas.Controls.Add(this.btnRefrigerante);
            this.grpBebidas.Controls.Add(this.btnAchocolatado);
            this.grpBebidas.Controls.Add(this.btnCoado);
            this.grpBebidas.Controls.Add(this.btnExpresso);
            this.grpBebidas.Controls.Add(this.btnCafeLeite);
            this.grpBebidas.ForeColor = System.Drawing.Color.White;
            this.grpBebidas.Location = new System.Drawing.Point(118, 261);
            this.grpBebidas.Name = "grpBebidas";
            this.grpBebidas.Size = new System.Drawing.Size(507, 270);
            this.grpBebidas.TabIndex = 16;
            this.grpBebidas.TabStop = false;
            this.grpBebidas.Text = "Bebidas";
            this.grpBebidas.Visible = false;
            // 
            // grpSalgados
            // 
            this.grpSalgados.BackColor = System.Drawing.Color.Transparent;
            this.grpSalgados.Controls.Add(this.btnBatata);
            this.grpSalgados.Controls.Add(this.btnFrango);
            this.grpSalgados.Controls.Add(this.btnPaoChapa);
            this.grpSalgados.Controls.Add(this.btnEmpadinha);
            this.grpSalgados.Controls.Add(this.btnMistoQuente);
            this.grpSalgados.ForeColor = System.Drawing.Color.White;
            this.grpSalgados.Location = new System.Drawing.Point(118, 261);
            this.grpSalgados.Name = "grpSalgados";
            this.grpSalgados.Size = new System.Drawing.Size(507, 270);
            this.grpSalgados.TabIndex = 17;
            this.grpSalgados.TabStop = false;
            this.grpSalgados.Text = "Salgados";
            this.grpSalgados.Visible = false;
            // 
            // grpSobremesas
            // 
            this.grpSobremesas.BackColor = System.Drawing.Color.Transparent;
            this.grpSobremesas.Controls.Add(this.btnBoloIndividual);
            this.grpSobremesas.Controls.Add(this.btnBoloInteiro);
            this.grpSobremesas.Controls.Add(this.btnBrownie);
            this.grpSobremesas.Controls.Add(this.btnAcai);
            this.grpSobremesas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpSobremesas.ForeColor = System.Drawing.Color.White;
            this.grpSobremesas.Location = new System.Drawing.Point(118, 260);
            this.grpSobremesas.Name = "grpSobremesas";
            this.grpSobremesas.Size = new System.Drawing.Size(507, 270);
            this.grpSobremesas.TabIndex = 18;
            this.grpSobremesas.TabStop = false;
            this.grpSobremesas.Text = "Sobremesas";
            this.grpSobremesas.Visible = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPagar.Location = new System.Drawing.Point(666, 535);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(121, 21);
            this.lblTotalPagar.TabIndex = 21;
            this.lblTotalPagar.Text = "Total a pagar:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(807, 536);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(150, 23);
            this.txtTotalPagar.TabIndex = 22;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(670, 570);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(137, 30);
            this.btnFinalizar.TabIndex = 23;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(838, 570);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 30);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir Linha";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.White;
            this.lblMesa.Location = new System.Drawing.Point(441, 54);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(54, 18);
            this.lblMesa.TabIndex = 25;
            this.lblMesa.Text = "Mesa:";
            // 
            // cboMesa
            // 
            this.cboMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboMesa.FormattingEnabled = true;
            this.cboMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Balcão"});
            this.cboMesa.Location = new System.Drawing.Point(501, 49);
            this.cboMesa.Name = "cboMesa";
            this.cboMesa.Size = new System.Drawing.Size(121, 26);
            this.cboMesa.TabIndex = 26;
            // 
            // frmTelaAtendimento
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 664);
            this.Controls.Add(this.cboMesa);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.grpCategorias);
            this.Controls.Add(this.dgvResumo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.grpBebidas);
            this.Controls.Add(this.grpSobremesas);
            this.Controls.Add(this.grpSalgados);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaAtendimento";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.frmTelaAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumo)).EndInit();
            this.grpCategorias.ResumeLayout(false);
            this.grpBebidas.ResumeLayout(false);
            this.grpSalgados.ResumeLayout(false);
            this.grpSobremesas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnSalgados;
        private System.Windows.Forms.Button btnSobremesas;
        private System.Windows.Forms.DataGridView dgvResumo;
        private System.Windows.Forms.ToolTip tipBotao;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.Button btnAcai;
        private System.Windows.Forms.Button btnBrownie;
        private System.Windows.Forms.Button btnBoloInteiro;
        private System.Windows.Forms.Button btnBoloIndividual;
        private System.Windows.Forms.Button btnPaoChapa;
        private System.Windows.Forms.Button btnMistoQuente;
        private System.Windows.Forms.Button btnEmpadinha;
        private System.Windows.Forms.Button btnFrango;
        private System.Windows.Forms.Button btnBatata;
        private System.Windows.Forms.Button btnRefrigerante;
        private System.Windows.Forms.Button btnAgua;
        private System.Windows.Forms.Button btnCappuccino;
        private System.Windows.Forms.Button btnAchocolatado;
        private System.Windows.Forms.Button btnCafeLeite;
        private System.Windows.Forms.Button btnCoado;
        private System.Windows.Forms.Button btnExpresso;
        private System.Windows.Forms.GroupBox grpBebidas;
        private System.Windows.Forms.GroupBox grpSalgados;
        private System.Windows.Forms.GroupBox grpSobremesas;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PdMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PdCliente;
        private System.Windows.Forms.ComboBox cboMesa;
    }
}