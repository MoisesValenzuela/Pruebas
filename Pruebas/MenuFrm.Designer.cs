namespace Pruebas
{
    partial class MenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resguardosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoreosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.cambiosToolStripMenuItem});
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.activosToolStripMenuItem.Text = "Activos";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.listarToolStripMenuItem.Tag = "1";
            this.listarToolStripMenuItem.Text = "Listar Activos";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.altaToolStripMenuItem.Tag = "2";
            this.altaToolStripMenuItem.Text = "Alta Activos";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.bajaToolStripMenuItem.Tag = "3";
            this.bajaToolStripMenuItem.Text = "Baja Activos";
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.cambiosToolStripMenuItem.Tag = "4";
            this.cambiosToolStripMenuItem.Text = "Cambios Activos";
            this.cambiosToolStripMenuItem.Click += new System.EventHandler(this.cambiosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resguardosToolStripMenuItem,
            this.monitoreosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // resguardosToolStripMenuItem
            // 
            this.resguardosToolStripMenuItem.Name = "resguardosToolStripMenuItem";
            this.resguardosToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.resguardosToolStripMenuItem.Tag = "5";
            this.resguardosToolStripMenuItem.Text = "Resguardos";
            this.resguardosToolStripMenuItem.Click += new System.EventHandler(this.resguardosToolStripMenuItem_Click);
            // 
            // monitoreosToolStripMenuItem
            // 
            this.monitoreosToolStripMenuItem.Name = "monitoreosToolStripMenuItem";
            this.monitoreosToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.monitoreosToolStripMenuItem.Tag = "6";
            this.monitoreosToolStripMenuItem.Text = "Monitoreo Trimestral";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.altaToolStripMenuItem1,
            this.bajaToolStripMenuItem1,
            this.cambiosToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(99, 32);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.listarToolStripMenuItem1.Tag = "7";
            this.listarToolStripMenuItem1.Text = "Listar Usuarios";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.altaToolStripMenuItem1.Tag = "8";
            this.altaToolStripMenuItem1.Text = "Alta Usuarios";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // bajaToolStripMenuItem1
            // 
            this.bajaToolStripMenuItem1.Name = "bajaToolStripMenuItem1";
            this.bajaToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.bajaToolStripMenuItem1.Tag = "9";
            this.bajaToolStripMenuItem1.Text = "Baja Usuarios";
            // 
            // cambiosToolStripMenuItem1
            // 
            this.cambiosToolStripMenuItem1.Name = "cambiosToolStripMenuItem1";
            this.cambiosToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.cambiosToolStripMenuItem1.Tag = "10";
            this.cambiosToolStripMenuItem1.Text = "Cambios Usuarios";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaRolesToolStripMenuItem,
            this.cambiosRolesToolStripMenuItem,
            this.bitacoraToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // altaRolesToolStripMenuItem
            // 
            this.altaRolesToolStripMenuItem.Name = "altaRolesToolStripMenuItem";
            this.altaRolesToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.altaRolesToolStripMenuItem.Tag = "11";
            this.altaRolesToolStripMenuItem.Text = "Alta Roles";
            this.altaRolesToolStripMenuItem.Click += new System.EventHandler(this.altaRolesToolStripMenuItem_Click);
            // 
            // cambiosRolesToolStripMenuItem
            // 
            this.cambiosRolesToolStripMenuItem.Name = "cambiosRolesToolStripMenuItem";
            this.cambiosRolesToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.cambiosRolesToolStripMenuItem.Tag = "12";
            this.cambiosRolesToolStripMenuItem.Text = "Cambios Roles";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.bitacoraToolStripMenuItem.Tag = "13";
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 427);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuFrm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resguardosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoreosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
    }
}