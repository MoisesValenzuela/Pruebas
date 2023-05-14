namespace Pruebas
{
    partial class VisualizacionActivosFrm
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbxCampos = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxTipoDatos = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivos
            // 
            this.dgvActivos.AllowUserToAddRows = false;
            this.dgvActivos.AllowUserToDeleteRows = false;
            this.dgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivos.Location = new System.Drawing.Point(12, 38);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.ReadOnly = true;
            this.dgvActivos.Size = new System.Drawing.Size(1007, 426);
            this.dgvActivos.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(483, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // cbxCampos
            // 
            this.cbxCampos.FormattingEnabled = true;
            this.cbxCampos.Location = new System.Drawing.Point(501, 11);
            this.cbxCampos.Name = "cbxCampos";
            this.cbxCampos.Size = new System.Drawing.Size(161, 21);
            this.cbxCampos.TabIndex = 2;
            this.cbxCampos.SelectedIndexChanged += new System.EventHandler(this.cbxCampos_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(668, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxTipoDatos
            // 
            this.cbxTipoDatos.Enabled = false;
            this.cbxTipoDatos.FormattingEnabled = true;
            this.cbxTipoDatos.Location = new System.Drawing.Point(898, 10);
            this.cbxTipoDatos.Name = "cbxTipoDatos";
            this.cbxTipoDatos.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoDatos.TabIndex = 4;
            this.cbxTipoDatos.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(749, 10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Busqueda";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // VisualizacionActivosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 476);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbxTipoDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxCampos);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvActivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualizacionActivosFrm";
            this.Text = "Activos Fijos";
            this.Load += new System.EventHandler(this.VisualizacionActivosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbxCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxTipoDatos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}