namespace LiquidacionesSqlFranciscoArmijo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textSueldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.textBoxRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lIQUIDACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRABAJADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIQUIDACION DE SUELDO MENSUAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonMostrar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textSueldo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textMes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textAnio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.textBoxRut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL TRABAJADOR";
            // 
            // botonMostrar
            // 
            this.botonMostrar.Location = new System.Drawing.Point(198, 182);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(214, 23);
            this.botonMostrar.TabIndex = 14;
            this.botonMostrar.Text = "MOSTRAR EN DATA GRID";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "GUARDAR DESDE TEXTBOX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSueldo
            // 
            this.textSueldo.Location = new System.Drawing.Point(206, 99);
            this.textSueldo.Name = "textSueldo";
            this.textSueldo.Size = new System.Drawing.Size(200, 22);
            this.textSueldo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sueldo:";
            // 
            // textMes
            // 
            this.textMes.Location = new System.Drawing.Point(367, 55);
            this.textMes.Name = "textMes";
            this.textMes.Size = new System.Drawing.Size(200, 22);
            this.textMes.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mes:";
            // 
            // textAnio
            // 
            this.textAnio.Location = new System.Drawing.Point(50, 55);
            this.textAnio.Name = "textAnio";
            this.textAnio.Size = new System.Drawing.Size(200, 22);
            this.textAnio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(367, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 22);
            this.textBoxNombre.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(299, 27);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(69, 17);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre:";
            // 
            // textBoxRut
            // 
            this.textBoxRut.Location = new System.Drawing.Point(50, 27);
            this.textBoxRut.Name = "textBoxRut";
            this.textBoxRut.Size = new System.Drawing.Size(200, 22);
            this.textBoxRut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rut:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 319);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIQUIDACIONToolStripMenuItem,
            this.tRABAJADORToolStripMenuItem,
            this.aPFToolStripMenuItem,
            this.sALUDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lIQUIDACIONToolStripMenuItem
            // 
            this.lIQUIDACIONToolStripMenuItem.Name = "lIQUIDACIONToolStripMenuItem";
            this.lIQUIDACIONToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.lIQUIDACIONToolStripMenuItem.Text = "lIQUIDACION";
            // 
            // tRABAJADORToolStripMenuItem
            // 
            this.tRABAJADORToolStripMenuItem.Name = "tRABAJADORToolStripMenuItem";
            this.tRABAJADORToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.tRABAJADORToolStripMenuItem.Text = "TRABAJADOR";
            this.tRABAJADORToolStripMenuItem.Click += new System.EventHandler(this.tRABAJADORToolStripMenuItem_Click);
            // 
            // aPFToolStripMenuItem
            // 
            this.aPFToolStripMenuItem.Name = "aPFToolStripMenuItem";
            this.aPFToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.aPFToolStripMenuItem.Text = "APF";
            // 
            // sALUDToolStripMenuItem
            // 
            this.sALUDToolStripMenuItem.Name = "sALUDToolStripMenuItem";
            this.sALUDToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.sALUDToolStripMenuItem.Text = "SALUD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LIQUIDACION";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textBoxRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lIQUIDACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRABAJADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALUDToolStripMenuItem;
    }
}

