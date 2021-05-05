namespace Client_Rest
{
    partial class Form1
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
            this.dgPais = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subregiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCSV = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPais
            // 
            this.dgPais.AllowUserToAddRows = false;
            this.dgPais.AllowUserToOrderColumns = true;
            this.dgPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.capital,
            this.regiao,
            this.subregiao,
            this.populacao,
            this.area,
            this.fuso,
            this.nativo,
            this.link});
            this.dgPais.Location = new System.Drawing.Point(21, 79);
            this.dgPais.Name = "dgPais";
            this.dgPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPais.Size = new System.Drawing.Size(885, 347);
            this.dgPais.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            // 
            // capital
            // 
            this.capital.HeaderText = "Capital";
            this.capital.Name = "capital";
            // 
            // regiao
            // 
            this.regiao.HeaderText = "Região";
            this.regiao.Name = "regiao";
            // 
            // subregiao
            // 
            this.subregiao.HeaderText = "Sub-Região";
            this.subregiao.Name = "subregiao";
            // 
            // populacao
            // 
            this.populacao.HeaderText = "População";
            this.populacao.Name = "populacao";
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            // 
            // fuso
            // 
            this.fuso.HeaderText = "Fuso Horário";
            this.fuso.Name = "fuso";
            // 
            // nativo
            // 
            this.nativo.HeaderText = "Nome Nativo";
            this.nativo.Name = "nativo";
            // 
            // link
            // 
            this.link.HeaderText = "Link da imagem";
            this.link.Name = "link";
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(21, 432);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 5;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(111, 432);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(140, 23);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Exportar em XLS";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(257, 432);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(140, 23);
            this.btnXml.TabIndex = 7;
            this.btnXml.Text = "Exportar em XML\r\n";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(184, 40);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(378, 20);
            this.txtFiltro.TabIndex = 8;
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Filtrar por",
            "Contem o nome",
            "Nome completo",
            "Capital",
            "Regiao"});
            this.cboFiltro.Location = new System.Drawing.Point(21, 39);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(157, 21);
            this.cboFiltro.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(568, 40);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Pesquisar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(934, 458);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.dgPais);
            this.Name = "Form1";
            this.Text = "API RestFull";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn regiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn subregiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn populacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.SaveFileDialog sfd;
        public System.Windows.Forms.DataGridView dgPais;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Button btnFiltrar;
    }
}

