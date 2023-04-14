namespace Pruebas
{
    partial class ResguardosFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.txtape2 = new System.Windows.Forms.TextBox();
            this.txtape1 = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.lblrfc = new System.Windows.Forms.Label();
            this.lblape2 = new System.Windows.Forms.Label();
            this.lblape1 = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDepFor = new System.Windows.Forms.TextBox();
            this.txtoffi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoRes = new System.Windows.Forms.TextBox();
            this.lblNoRes = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblunit = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.lblcant = new System.Windows.Forms.Label();
            this.lblactivo = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.btnterminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrfc);
            this.groupBox1.Controls.Add(this.txtape2);
            this.groupBox1.Controls.Add(this.txtape1);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Controls.Add(this.lblrfc);
            this.groupBox1.Controls.Add(this.lblape2);
            this.groupBox1.Controls.Add(this.lblape1);
            this.groupBox1.Controls.Add(this.lblnombres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Empleado";
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(139, 147);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(305, 26);
            this.txtrfc.TabIndex = 7;
            this.txtrfc.TextChanged += new System.EventHandler(this.txtrfc_TextChanged);
            // 
            // txtape2
            // 
            this.txtape2.Location = new System.Drawing.Point(139, 111);
            this.txtape2.Name = "txtape2";
            this.txtape2.Size = new System.Drawing.Size(305, 26);
            this.txtape2.TabIndex = 6;
            // 
            // txtape1
            // 
            this.txtape1.Location = new System.Drawing.Point(139, 75);
            this.txtape1.Name = "txtape1";
            this.txtape1.Size = new System.Drawing.Size(305, 26);
            this.txtape1.TabIndex = 5;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(139, 39);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(305, 26);
            this.txtnombres.TabIndex = 4;
            // 
            // lblrfc
            // 
            this.lblrfc.AutoSize = true;
            this.lblrfc.Location = new System.Drawing.Point(87, 150);
            this.lblrfc.Name = "lblrfc";
            this.lblrfc.Size = new System.Drawing.Size(46, 20);
            this.lblrfc.TabIndex = 3;
            this.lblrfc.Text = "RFC:";
            // 
            // lblape2
            // 
            this.lblape2.AutoSize = true;
            this.lblape2.Location = new System.Drawing.Point(29, 114);
            this.lblape2.Name = "lblape2";
            this.lblape2.Size = new System.Drawing.Size(104, 20);
            this.lblape2.TabIndex = 2;
            this.lblape2.Text = "2do. Apellido:";
            // 
            // lblape1
            // 
            this.lblape1.AutoSize = true;
            this.lblape1.Location = new System.Drawing.Point(33, 78);
            this.lblape1.Name = "lblape1";
            this.lblape1.Size = new System.Drawing.Size(100, 20);
            this.lblape1.TabIndex = 1;
            this.lblape1.Text = "1er. Apellido:";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(46, 42);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(87, 20);
            this.lblnombres.TabIndex = 0;
            this.lblnombres.Text = "Nombre(s):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDepFor);
            this.groupBox2.Controls.Add(this.txtoffi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNoRes);
            this.groupBox2.Controls.Add(this.lblNoRes);
            this.groupBox2.Controls.Add(this.lblfecha);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(480, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Resguardo";
            // 
            // txtDepFor
            // 
            this.txtDepFor.Location = new System.Drawing.Point(217, 150);
            this.txtDepFor.Name = "txtDepFor";
            this.txtDepFor.Size = new System.Drawing.Size(264, 26);
            this.txtDepFor.TabIndex = 7;
            // 
            // txtoffi
            // 
            this.txtoffi.Location = new System.Drawing.Point(217, 114);
            this.txtoffi.Name = "txtoffi";
            this.txtoffi.Size = new System.Drawing.Size(264, 26);
            this.txtoffi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dependencia Foranea:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oficina:";
            // 
            // txtNoRes
            // 
            this.txtNoRes.Location = new System.Drawing.Point(217, 78);
            this.txtNoRes.Name = "txtNoRes";
            this.txtNoRes.Size = new System.Drawing.Size(264, 26);
            this.txtNoRes.TabIndex = 3;
            // 
            // lblNoRes
            // 
            this.lblNoRes.AutoSize = true;
            this.lblNoRes.Location = new System.Drawing.Point(91, 81);
            this.lblNoRes.Name = "lblNoRes";
            this.lblNoRes.Size = new System.Drawing.Size(120, 20);
            this.lblNoRes.TabIndex = 2;
            this.lblNoRes.Text = "No. Resguardo:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(45, 38);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(166, 20);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "Fecha del Resguardo:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(217, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(342, 26);
            this.dtpFecha.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblunit);
            this.groupBox3.Controls.Add(this.btnagregar);
            this.groupBox3.Controls.Add(this.txtunit);
            this.groupBox3.Controls.Add(this.txtcant);
            this.groupBox3.Controls.Add(this.lblcant);
            this.groupBox3.Controls.Add(this.lblactivo);
            this.groupBox3.Controls.Add(this.cbActivo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 196);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles de Activos";
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Location = new System.Drawing.Point(46, 147);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(64, 20);
            this.lblunit.TabIndex = 5;
            this.lblunit.Text = "Unidad:";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Location = new System.Drawing.Point(296, 113);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(124, 37);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(116, 144);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(107, 26);
            this.txtunit.TabIndex = 4;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(116, 94);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(107, 26);
            this.txtcant.TabIndex = 3;
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Location = new System.Drawing.Point(33, 97);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(77, 20);
            this.lblcant.TabIndex = 2;
            this.lblcant.Text = "Cantidad:";
            // 
            // lblactivo
            // 
            this.lblactivo.AutoSize = true;
            this.lblactivo.Location = new System.Drawing.Point(54, 45);
            this.lblactivo.Name = "lblactivo";
            this.lblactivo.Size = new System.Drawing.Size(56, 20);
            this.lblactivo.TabIndex = 1;
            this.lblactivo.Text = "Activo:";
            // 
            // cbActivo
            // 
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Location = new System.Drawing.Point(116, 42);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(328, 28);
            this.cbActivo.TabIndex = 0;
            // 
            // dgvActivos
            // 
            this.dgvActivos.AllowUserToAddRows = false;
            this.dgvActivos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivos.ColumnHeadersHeight = 30;
            this.dgvActivos.EnableHeadersVisualStyles = false;
            this.dgvActivos.GridColor = System.Drawing.Color.DimGray;
            this.dgvActivos.Location = new System.Drawing.Point(480, 223);
            this.dgvActivos.MultiSelect = false;
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.ReadOnly = true;
            this.dgvActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivos.Size = new System.Drawing.Size(574, 186);
            this.dgvActivos.TabIndex = 3;
            // 
            // btnterminar
            // 
            this.btnterminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnterminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnterminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnterminar.ForeColor = System.Drawing.Color.Black;
            this.btnterminar.Location = new System.Drawing.Point(930, 415);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(124, 37);
            this.btnterminar.TabIndex = 5;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = false;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // ResguardosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 466);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.dgvActivos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResguardosFrm";
            this.Text = "ResguardosFrm";
            this.Load += new System.EventHandler(this.ResguardosFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvActivos;
        private System.Windows.Forms.Label lblrfc;
        private System.Windows.Forms.Label lblape2;
        private System.Windows.Forms.Label lblape1;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblNoRes;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.TextBox txtape2;
        private System.Windows.Forms.TextBox txtape1;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtNoRes;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Label lblactivo;
        private System.Windows.Forms.ComboBox cbActivo;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.TextBox txtDepFor;
        private System.Windows.Forms.TextBox txtoffi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}