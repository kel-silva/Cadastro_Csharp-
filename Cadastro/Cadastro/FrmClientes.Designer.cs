namespace Cadastro
{
    partial class FrmMenuClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btFicha = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFicha);
            this.groupBox1.Controls.Add(this.btRelatorio);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acoes";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(6, 30);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(59, 48);
            this.btAdd.TabIndex = 1;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Transparent;
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.Enabled = false;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(93, 30);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(48, 48);
            this.btEditar.TabIndex = 1;
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btRelatorio
            // 
            this.btRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.Location = new System.Drawing.Point(169, 30);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(48, 48);
            this.btRelatorio.TabIndex = 1;
            this.btRelatorio.UseVisualStyleBackColor = false;
            // 
            // btFicha
            // 
            this.btFicha.BackColor = System.Drawing.Color.Transparent;
            this.btFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFicha.Enabled = false;
            this.btFicha.FlatAppearance.BorderSize = 0;
            this.btFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFicha.Image = ((System.Drawing.Image)(resources.GetObject("btFicha.Image")));
            this.btFicha.Location = new System.Drawing.Point(245, 30);
            this.btFicha.Name = "btFicha";
            this.btFicha.Size = new System.Drawing.Size(48, 48);
            this.btFicha.TabIndex = 1;
            this.btFicha.UseVisualStyleBackColor = false;
            // 
            // FrmMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "FrmMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Clientes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFicha;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btEditar;
    }
}