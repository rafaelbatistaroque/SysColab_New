namespace SysColab.UI
{
    partial class Home
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
            this.BtnRH = new System.Windows.Forms.Button();
            this.BtnServicos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pagePrestadores = new SysColab.UI.PRESTADORES.Pages.PrestadorPage.PagePrestadores();
            this.pageFuncionarios = new SysColab.UI.RH.Pages.FuncionarioPage.PageFuncionarios();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRH
            // 
            this.BtnRH.BackColor = System.Drawing.Color.Transparent;
            this.BtnRH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRH.FlatAppearance.BorderSize = 0;
            this.BtnRH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.BtnRH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnRH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRH.Location = new System.Drawing.Point(0, 0);
            this.BtnRH.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRH.Name = "BtnRH";
            this.BtnRH.Size = new System.Drawing.Size(130, 50);
            this.BtnRH.TabIndex = 1;
            this.BtnRH.Text = "RH";
            this.BtnRH.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnRH.UseVisualStyleBackColor = false;
            this.BtnRH.Click += new System.EventHandler(this.BtnRH_Click);
            // 
            // BtnServicos
            // 
            this.BtnServicos.BackColor = System.Drawing.Color.Transparent;
            this.BtnServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnServicos.FlatAppearance.BorderSize = 0;
            this.BtnServicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.BtnServicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnServicos.Location = new System.Drawing.Point(0, 50);
            this.BtnServicos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnServicos.Name = "BtnServicos";
            this.BtnServicos.Size = new System.Drawing.Size(130, 36);
            this.BtnServicos.TabIndex = 1;
            this.BtnServicos.Text = "SERVIÇOS";
            this.BtnServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnServicos.UseVisualStyleBackColor = false;
            this.BtnServicos.Click += new System.EventHandler(this.BtnServicos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.flowLayoutPanel1.Controls.Add(this.BtnRH);
            this.flowLayoutPanel1.Controls.Add(this.BtnServicos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 500);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pagePrestadores
            // 
            this.pagePrestadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagePrestadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pagePrestadores.Location = new System.Drawing.Point(130, 64);
            this.pagePrestadores.Name = "pagePrestadores";
            this.pagePrestadores.Size = new System.Drawing.Size(850, 460);
            this.pagePrestadores.TabIndex = 2;
            // 
            // pageFuncionarios
            // 
            this.pageFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pageFuncionarios.Location = new System.Drawing.Point(130, 64);
            this.pageFuncionarios.Name = "pageFuncionarios";
            this.pageFuncionarios.Size = new System.Drawing.Size(850, 460);
            this.pageFuncionarios.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(980, 524);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pagePrestadores);
            this.Controls.Add(this.pageFuncionarios);
            this.Name = "Home";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RH.Pages.FuncionarioPage.PageFuncionarios pageFuncionarios;
        private PRESTADORES.Pages.PrestadorPage.PagePrestadores pagePrestadores;
        private System.Windows.Forms.Button BtnRH;
        private System.Windows.Forms.Button BtnServicos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

