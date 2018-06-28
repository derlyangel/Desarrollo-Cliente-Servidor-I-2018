namespace SistemaHorarioUniversidad
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pabellonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diasPorSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pabellonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horarioToolStripMenuItem,
            this.docentesToolStripMenuItem1,
            this.alumnosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.lugarToolStripMenuItem});
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.generarToolStripMenuItem.Text = "Datos";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diasPorSemanaToolStripMenuItem,
            this.horasToolStripMenuItem});
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horarioToolStripMenuItem.Text = "Horas y Dias";
            this.horarioToolStripMenuItem.Click += new System.EventHandler(this.horarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docentesToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.aulasToolStripMenuItem,
            this.pabellonToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.salirToolStripMenuItem.Text = "Asignar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.docentesToolStripMenuItem.Text = "Docentes";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // aulasToolStripMenuItem
            // 
            this.aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            this.aulasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aulasToolStripMenuItem.Text = "Aulas";
            // 
            // pabellonToolStripMenuItem
            // 
            this.pabellonToolStripMenuItem.Name = "pabellonToolStripMenuItem";
            this.pabellonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pabellonToolStripMenuItem.Text = "Pabellon";
            // 
            // diasPorSemanaToolStripMenuItem
            // 
            this.diasPorSemanaToolStripMenuItem.Name = "diasPorSemanaToolStripMenuItem";
            this.diasPorSemanaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.diasPorSemanaToolStripMenuItem.Text = "Dias por semana";
            this.diasPorSemanaToolStripMenuItem.Click += new System.EventHandler(this.diasPorSemanaToolStripMenuItem_Click);
            // 
            // horasToolStripMenuItem
            // 
            this.horasToolStripMenuItem.Name = "horasToolStripMenuItem";
            this.horasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.horasToolStripMenuItem.Text = "Horas(periodos) por dia";
            // 
            // docentesToolStripMenuItem1
            // 
            this.docentesToolStripMenuItem1.Name = "docentesToolStripMenuItem1";
            this.docentesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.docentesToolStripMenuItem1.Text = "Docentes";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // lugarToolStripMenuItem
            // 
            this.lugarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pabellonesToolStripMenuItem,
            this.aulasToolStripMenuItem1});
            this.lugarToolStripMenuItem.Name = "lugarToolStripMenuItem";
            this.lugarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lugarToolStripMenuItem.Text = "Lugar";
            // 
            // pabellonesToolStripMenuItem
            // 
            this.pabellonesToolStripMenuItem.Name = "pabellonesToolStripMenuItem";
            this.pabellonesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pabellonesToolStripMenuItem.Text = "Pabellones";
            // 
            // aulasToolStripMenuItem1
            // 
            this.aulasToolStripMenuItem1.Name = "aulasToolStripMenuItem1";
            this.aulasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aulasToolStripMenuItem1.Text = "Aulas";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 435);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pabellonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diasPorSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pabellonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem1;
    }
}