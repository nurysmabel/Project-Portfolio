namespace Suplidores3.Data.View
{
    partial class frmBuscarRnc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarRnc));
            this.dgvBuscarRnc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnRNC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarRnc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarRnc
            // 
            this.dgvBuscarRnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarRnc.Location = new System.Drawing.Point(12, 116);
            this.dgvBuscarRnc.Name = "dgvBuscarRnc";
            this.dgvBuscarRnc.Size = new System.Drawing.Size(412, 150);
            this.dgvBuscarRnc.TabIndex = 0;
            this.dgvBuscarRnc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarRnc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserte el RNC a buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(15, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(127, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnRNC
            // 
            this.btnRNC.Location = new System.Drawing.Point(174, 55);
            this.btnRNC.Name = "btnRNC";
            this.btnRNC.Size = new System.Drawing.Size(75, 23);
            this.btnRNC.TabIndex = 3;
            this.btnRNC.Text = "Buscar";
            this.btnRNC.UseVisualStyleBackColor = true;
            this.btnRNC.Click += new System.EventHandler(this.btnRNC_Click);
            // 
            // frmBuscarRnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 278);
            this.Controls.Add(this.btnRNC);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarRnc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarRnc";
            this.Text = "frmBuscarRnc";
            this.Load += new System.EventHandler(this.frmBuscarRnc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarRnc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarRnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnRNC;
    }
}