namespace SysColab.UI.PRESTADORES.Pages.PrestadorPage
{
    partial class NovoPrestador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoPrestador));
            this.BtnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            resources.ApplyResources(this.BtnCancelar, "BtnCancelar");
            this.BtnCancelar.Depth = 0;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Primary = false;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            resources.ApplyResources(this.BtnSalvar, "BtnSalvar");
            this.BtnSalvar.Depth = 0;
            this.BtnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Primary = false;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // NovoPrestador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.BtnCancelar;
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "NovoPrestador";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton BtnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton BtnSalvar;
    }
}