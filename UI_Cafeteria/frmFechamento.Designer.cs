
namespace UI_Cafeteria
{
    partial class frmFechamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.gpoInfoPed = new System.Windows.Forms.GroupBox();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodPed = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gpoLista = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaCliente = new System.Windows.Forms.TextBox();
            this.btnExcluirPed = new System.Windows.Forms.Button();
            this.btnAtualizarPed = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.txtPesquisaMesa = new System.Windows.Forms.TextBox();
            this.pnlProdutos.SuspendLayout();
            this.gpoInfoPed.SuspendLayout();
            this.gpoLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.BackColor = System.Drawing.Color.Transparent;
            this.pnlProdutos.Controls.Add(this.gpoInfoPed);
            this.pnlProdutos.Controls.Add(this.gpoLista);
            this.pnlProdutos.Location = new System.Drawing.Point(12, 12);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(1005, 693);
            this.pnlProdutos.TabIndex = 2;
            // 
            // gpoInfoPed
            // 
            this.gpoInfoPed.BackColor = System.Drawing.Color.Transparent;
            this.gpoInfoPed.Controls.Add(this.txtMesa);
            this.gpoInfoPed.Controls.Add(this.txtCliente);
            this.gpoInfoPed.Controls.Add(this.lblMesa);
            this.gpoInfoPed.Controls.Add(this.btnLimpar);
            this.gpoInfoPed.Controls.Add(this.lblCliente);
            this.gpoInfoPed.Controls.Add(this.lblCodPed);
            this.gpoInfoPed.Controls.Add(this.txtStatus);
            this.gpoInfoPed.Controls.Add(this.txtCodPed);
            this.gpoInfoPed.Controls.Add(this.lblStatus);
            this.gpoInfoPed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoInfoPed.ForeColor = System.Drawing.Color.White;
            this.gpoInfoPed.Location = new System.Drawing.Point(198, 0);
            this.gpoInfoPed.Name = "gpoInfoPed";
            this.gpoInfoPed.Size = new System.Drawing.Size(587, 208);
            this.gpoInfoPed.TabIndex = 17;
            this.gpoInfoPed.TabStop = false;
            this.gpoInfoPed.Text = "Informações do pedido";
            // 
            // txtMesa
            // 
            this.txtMesa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.Location = new System.Drawing.Point(126, 82);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(149, 26);
            this.txtMesa.TabIndex = 1;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(382, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(147, 26);
            this.txtCliente.TabIndex = 2;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.White;
            this.lblMesa.Location = new System.Drawing.Point(68, 86);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(52, 18);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Mesa:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(459, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 30);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(311, 43);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(65, 18);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblCodPed
            // 
            this.lblCodPed.AutoSize = true;
            this.lblCodPed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPed.ForeColor = System.Drawing.Color.White;
            this.lblCodPed.Location = new System.Drawing.Point(68, 43);
            this.lblCodPed.Name = "lblCodPed";
            this.lblCodPed.Size = new System.Drawing.Size(124, 18);
            this.lblCodPed.TabIndex = 3;
            this.lblCodPed.Text = "Cód do Pedido:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(382, 82);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(147, 26);
            this.txtStatus.TabIndex = 3;
            // 
            // txtCodPed
            // 
            this.txtCodPed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPed.Location = new System.Drawing.Point(198, 39);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(77, 26);
            this.txtCodPed.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(311, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // gpoLista
            // 
            this.gpoLista.BackColor = System.Drawing.Color.Transparent;
            this.gpoLista.Controls.Add(this.label2);
            this.gpoLista.Controls.Add(this.label1);
            this.gpoLista.Controls.Add(this.txtPesquisaCliente);
            this.gpoLista.Controls.Add(this.btnExcluirPed);
            this.gpoLista.Controls.Add(this.btnAtualizarPed);
            this.gpoLista.Controls.Add(this.dgvListar);
            this.gpoLista.Controls.Add(this.txtPesquisaMesa);
            this.gpoLista.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoLista.ForeColor = System.Drawing.Color.White;
            this.gpoLista.Location = new System.Drawing.Point(198, 214);
            this.gpoLista.Name = "gpoLista";
            this.gpoLista.Size = new System.Drawing.Size(585, 303);
            this.gpoLista.TabIndex = 18;
            this.gpoLista.TabStop = false;
            this.gpoLista.Text = "Lista de pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mesa:";
            // 
            // txtPesquisaCliente
            // 
            this.txtPesquisaCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCliente.Location = new System.Drawing.Point(323, 24);
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.Size = new System.Drawing.Size(206, 26);
            this.txtPesquisaCliente.TabIndex = 10;
            this.txtPesquisaCliente.TextChanged += new System.EventHandler(this.txtPesquisaCliente_TextChanged);
            // 
            // btnExcluirPed
            // 
            this.btnExcluirPed.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirPed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirPed.BackgroundImage")));
            this.btnExcluirPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirPed.FlatAppearance.BorderSize = 0;
            this.btnExcluirPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPed.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirPed.Location = new System.Drawing.Point(484, 250);
            this.btnExcluirPed.Name = "btnExcluirPed";
            this.btnExcluirPed.Size = new System.Drawing.Size(45, 45);
            this.btnExcluirPed.TabIndex = 11;
            this.btnExcluirPed.UseVisualStyleBackColor = false;
            this.btnExcluirPed.Click += new System.EventHandler(this.btnExcluirPed_Click);
            // 
            // btnAtualizarPed
            // 
            this.btnAtualizarPed.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizarPed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizarPed.BackgroundImage")));
            this.btnAtualizarPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizarPed.FlatAppearance.BorderSize = 0;
            this.btnAtualizarPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarPed.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizarPed.Location = new System.Drawing.Point(437, 250);
            this.btnAtualizarPed.Name = "btnAtualizarPed";
            this.btnAtualizarPed.Size = new System.Drawing.Size(45, 45);
            this.btnAtualizarPed.TabIndex = 10;
            this.btnAtualizarPed.UseVisualStyleBackColor = false;
            this.btnAtualizarPed.Click += new System.EventHandler(this.btnAtualizarPed_Click);
            // 
            // dgvListar
            // 
            this.dgvListar.AllowUserToAddRows = false;
            this.dgvListar.AllowUserToDeleteRows = false;
            this.dgvListar.BackgroundColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListar.Location = new System.Drawing.Point(78, 56);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(451, 188);
            this.dgvListar.TabIndex = 9;
            this.dgvListar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListar_CellClick);
            // 
            // txtPesquisaMesa
            // 
            this.txtPesquisaMesa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMesa.Location = new System.Drawing.Point(133, 24);
            this.txtPesquisaMesa.Name = "txtPesquisaMesa";
            this.txtPesquisaMesa.Size = new System.Drawing.Size(113, 26);
            this.txtPesquisaMesa.TabIndex = 9;
            this.txtPesquisaMesa.TextChanged += new System.EventHandler(this.txtPesquisaMesa_TextChanged);
            // 
            // frmFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 664);
            this.Controls.Add(this.pnlProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFechamento";
            this.Text = "Fechamento";
            this.Load += new System.EventHandler(this.frmFechamento_Load);
            this.pnlProdutos.ResumeLayout(false);
            this.gpoInfoPed.ResumeLayout(false);
            this.gpoInfoPed.PerformLayout();
            this.gpoLista.ResumeLayout(false);
            this.gpoLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.GroupBox gpoInfoPed;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCodPed;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gpoLista;
        private System.Windows.Forms.Button btnExcluirPed;
        private System.Windows.Forms.Button btnAtualizarPed;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.TextBox txtPesquisaMesa;
        private System.Windows.Forms.TextBox txtPesquisaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}