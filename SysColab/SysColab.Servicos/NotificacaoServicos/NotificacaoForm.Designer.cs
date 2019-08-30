namespace SysColab.Dominio.Compartilhados.Entities.NotificacaoServico
{
    partial class NotificacaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificacaoForm));
            this.lblNotificacao = new System.Windows.Forms.Label();
            this.timerNotificacao = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotificacao.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotificacao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNotificacao.Location = new System.Drawing.Point(12, 9);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(250, 75);
            this.lblNotificacao.TabIndex = 0;
            this.lblNotificacao.Text = "Notificacao";
            this.lblNotificacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerNotificacao
            // 
            this.timerNotificacao.Enabled = true;
            this.timerNotificacao.Interval = 4000;
            this.timerNotificacao.Tick += new System.EventHandler(this.TimerNotificacao_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(285, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NotificacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(350, 95);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNotificacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificacaoForm";
            this.Text = "Notificacao";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notificacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotificacao;
        private System.Windows.Forms.Timer timerNotificacao;
        private System.Windows.Forms.Button button1;
    }
}