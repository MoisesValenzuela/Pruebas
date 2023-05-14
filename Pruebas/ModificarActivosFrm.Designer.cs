namespace Pruebas
{
    partial class ModificarActivosFrm
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
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.txtNoControlInv = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCambios = new System.Windows.Forms.Label();
            this.rtxtCambios = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtMonitoreo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivos
            // 
            this.dgvActivos.AllowUserToAddRows = false;
            this.dgvActivos.AllowUserToDeleteRows = false;
            this.dgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivos.Location = new System.Drawing.Point(12, 121);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.ReadOnly = true;
            this.dgvActivos.Size = new System.Drawing.Size(1070, 317);
            this.dgvActivos.TabIndex = 0;
            this.dgvActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivos_CellContentClick);
            // 
            // txtNoControlInv
            // 
            this.txtNoControlInv.Location = new System.Drawing.Point(12, 25);
            this.txtNoControlInv.Name = "txtNoControlInv";
            this.txtNoControlInv.Size = new System.Drawing.Size(356, 20);
            this.txtNoControlInv.TabIndex = 1;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(374, 25);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(304, 20);
            this.txtImporte.TabIndex = 2;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(684, 25);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(265, 20);
            this.txtRFC.TabIndex = 3;
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(12, 64);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(356, 51);
            this.rtxtDescripcion.TabIndex = 5;
            this.rtxtDescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número de control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Importe";
            // 
            // lblCambios
            // 
            this.lblCambios.AutoSize = true;
            this.lblCambios.Location = new System.Drawing.Point(371, 48);
            this.lblCambios.Name = "lblCambios";
            this.lblCambios.Size = new System.Drawing.Size(47, 13);
            this.lblCambios.TabIndex = 9;
            this.lblCambios.Text = "Cambios";
            // 
            // rtxtCambios
            // 
            this.rtxtCambios.Location = new System.Drawing.Point(374, 64);
            this.rtxtCambios.Name = "rtxtCambios";
            this.rtxtCambios.Size = new System.Drawing.Size(304, 51);
            this.rtxtCambios.TabIndex = 10;
            this.rtxtCambios.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RFC";
            // 
            // rtxtMonitoreo
            // 
            this.rtxtMonitoreo.Location = new System.Drawing.Point(684, 64);
            this.rtxtMonitoreo.Name = "rtxtMonitoreo";
            this.rtxtMonitoreo.Size = new System.Drawing.Size(265, 51);
            this.rtxtMonitoreo.TabIndex = 12;
            this.rtxtMonitoreo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monitoreo";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(955, 17);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 90);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ModificarActivosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtMonitoreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtCambios);
            this.Controls.Add(this.lblCambios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtNoControlInv);
            this.Controls.Add(this.dgvActivos);
            this.Name = "ModificarActivosFrm";
            this.Text = "ModificarActivosFrm";
            this.Load += new System.EventHandler(this.ModificarActivosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivos;
        private System.Windows.Forms.TextBox txtNoControlInv;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCambios;
        private System.Windows.Forms.RichTextBox rtxtCambios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtMonitoreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificar;
    }
}