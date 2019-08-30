namespace SysColab.UI.PRESTADORES.Pages.PrestadorPage
{
    partial class PagePrestadores
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrestadores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtPesquisarPrestado = new System.Windows.Forms.TextBox();
            this.btnNovo = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestadores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrestadores
            // 
            this.dgvPrestadores.AllowUserToAddRows = false;
            this.dgvPrestadores.AllowUserToDeleteRows = false;
            this.dgvPrestadores.AllowUserToResizeColumns = false;
            this.dgvPrestadores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvPrestadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPrestadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrestadores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPrestadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestadores.ColumnHeadersHeight = 30;
            this.dgvPrestadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestadores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestadores.EnableHeadersVisualStyles = false;
            this.dgvPrestadores.Location = new System.Drawing.Point(30, 143);
            this.dgvPrestadores.MultiSelect = false;
            this.dgvPrestadores.Name = "dgvPrestadores";
            this.dgvPrestadores.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestadores.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvPrestadores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrestadores.RowTemplate.Height = 36;
            this.dgvPrestadores.RowTemplate.ReadOnly = true;
            this.dgvPrestadores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPrestadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestadores.ShowCellErrors = false;
            this.dgvPrestadores.ShowCellToolTips = false;
            this.dgvPrestadores.ShowRowErrors = false;
            this.dgvPrestadores.Size = new System.Drawing.Size(780, 266);
            this.dgvPrestadores.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.txtPesquisarPrestado);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 173);
            this.panel1.TabIndex = 8;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(610, 129);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(200, 2);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtPesquisarPrestado
            // 
            this.txtPesquisarPrestado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarPrestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.txtPesquisarPrestado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisarPrestado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarPrestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPesquisarPrestado.Location = new System.Drawing.Point(610, 99);
            this.txtPesquisarPrestado.Name = "txtPesquisarPrestado";
            this.txtPesquisarPrestado.Size = new System.Drawing.Size(200, 28);
            this.txtPesquisarPrestado.TabIndex = 6;
            this.txtPesquisarPrestado.Text = "Pesquisar...";
            this.txtPesquisarPrestado.Enter += new System.EventHandler(this.TxtPesquisarPrestado_Enter);
            this.txtPesquisarPrestado.Leave += new System.EventHandler(this.TxtPesquisarPrestado_Leave);
            this.txtPesquisarPrestado.MouseHover += new System.EventHandler(this.TxtPesquisarPrestado_MouseHover);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(31, 96);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = false;
            this.btnNovo.Size = new System.Drawing.Size(50, 36);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Depth = 0;
            this.BtnExcluir.Location = new System.Drawing.Point(735, 420);
            this.BtnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Primary = true;
            this.BtnExcluir.Size = new System.Drawing.Size(75, 26);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // PagePrestadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.dgvPrestadores);
            this.Controls.Add(this.panel1);
            this.Name = "PagePrestadores";
            this.Size = new System.Drawing.Size(840, 460);
            this.Load += new System.EventHandler(this.PagePrestador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestadores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestadores;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TextBox txtPesquisarPrestado;
        private MaterialSkin.Controls.MaterialFlatButton btnNovo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnExcluir;
    }
}
