namespace Suplidores3.Data.View
{
    partial class frmBorrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrar));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBorrarS = new System.Windows.Forms.Button();
            this.dgvBorrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(129, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBorrarS
            // 
            this.btnBorrarS.Location = new System.Drawing.Point(237, 12);
            this.btnBorrarS.Name = "btnBorrarS";
            this.btnBorrarS.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarS.TabIndex = 2;
            this.btnBorrarS.Text = "Borrar";
            this.btnBorrarS.UseVisualStyleBackColor = true;
            this.btnBorrarS.Click += new System.EventHandler(this.btnBorrarS_Click);
            // 
            // dgvBorrar
            // 
            this.dgvBorrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrar.Location = new System.Drawing.Point(12, 61);
            this.dgvBorrar.Name = "dgvBorrar";
            this.dgvBorrar.Size = new System.Drawing.Size(340, 94);
            this.dgvBorrar.TabIndex = 3;
            // 
            // frmBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 167);
            this.Controls.Add(this.dgvBorrar);
            this.Controls.Add(this.btnBorrarS);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBorrar";
            this.Text = "frmBorrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBorrarS;
        private System.Windows.Forms.DataGridView dgvBorrar;
    }
}