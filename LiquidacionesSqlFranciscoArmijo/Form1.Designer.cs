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
            this.label3 = new System.Windows.Forms.Label();
            this.textAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tRABAJADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboRut = new System.Windows.Forms.ComboBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBase = new System.Windows.Forms.TextBox();
            this.textOtrosImponibles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTotalImponible = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textFamiliar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMovilizacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textCargas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.labelHaberes = new System.Windows.Forms.Label();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textOtrosDescuentos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textOtrosPrev = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textVoluntarioAFP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textSalud = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textAFP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.BotonPDF = new System.Windows.Forms.Button();
            this.comboCorrelativo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIQUIDACION DE SUELDO MENSUAL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.comboMes);
            this.groupBox1.Controls.Add(this.comboRut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textAnio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL TRABAJADOR";
            // 
            // botonMostrar
            // 
            this.botonMostrar.Location = new System.Drawing.Point(280, 706);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(214, 23);
            this.botonMostrar.TabIndex = 14;
            this.botonMostrar.Text = "MOSTRAR EN DATA GRID";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(533, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "GUARDAR LIQUIDACION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mes:";
            // 
            // textAnio
            // 
            this.textAnio.Location = new System.Drawing.Point(108, 55);
            this.textAnio.Name = "textAnio";
            this.textAnio.Size = new System.Drawing.Size(200, 22);
            this.textAnio.TabIndex = 7;
            this.textAnio.Click += new System.EventHandler(this.textAnio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(452, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 22);
            this.textBoxNombre.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(384, 27);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(69, 17);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rut:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 735);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 156);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRABAJADORToolStripMenuItem,
            this.aPFToolStripMenuItem,
            this.sALUDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            this.aPFToolStripMenuItem.Text = "AFP";
            this.aPFToolStripMenuItem.Click += new System.EventHandler(this.aPFToolStripMenuItem_Click);
            // 
            // sALUDToolStripMenuItem
            // 
            this.sALUDToolStripMenuItem.Name = "sALUDToolStripMenuItem";
            this.sALUDToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.sALUDToolStripMenuItem.Text = "SALUD";
            this.sALUDToolStripMenuItem.Click += new System.EventHandler(this.sALUDToolStripMenuItem_Click);
            // 
            // comboRut
            // 
            this.comboRut.ForeColor = System.Drawing.Color.Black;
            this.comboRut.FormattingEnabled = true;
            this.comboRut.Location = new System.Drawing.Point(108, 27);
            this.comboRut.Name = "comboRut";
            this.comboRut.Size = new System.Drawing.Size(200, 24);
            this.comboRut.TabIndex = 5;
            this.comboRut.SelectedIndexChanged += new System.EventHandler(this.comboRut_SelectedIndexChanged);
            // 
            // comboMes
            // 
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboMes.Location = new System.Drawing.Point(452, 55);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(200, 24);
            this.comboMes.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.textCargas);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textMovilizacion);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textFamiliar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textTotalImponible);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textOtrosImponibles);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBase);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(18, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 217);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HABERES DEL TRABAJADOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sueldo Base:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "DETALLES DE REMUNERACION";
            // 
            // textBase
            // 
            this.textBase.Location = new System.Drawing.Point(452, 27);
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(200, 22);
            this.textBase.TabIndex = 16;
            this.textBase.Text = "0";
            // 
            // textOtrosImponibles
            // 
            this.textOtrosImponibles.Location = new System.Drawing.Point(452, 55);
            this.textOtrosImponibles.Name = "textOtrosImponibles";
            this.textOtrosImponibles.Size = new System.Drawing.Size(200, 22);
            this.textOtrosImponibles.TabIndex = 18;
            this.textOtrosImponibles.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Otros Ingresos Imponibles:";
            // 
            // textTotalImponible
            // 
            this.textTotalImponible.Location = new System.Drawing.Point(452, 83);
            this.textTotalImponible.Name = "textTotalImponible";
            this.textTotalImponible.Size = new System.Drawing.Size(200, 22);
            this.textTotalImponible.TabIndex = 20;
            this.textTotalImponible.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Remuneracion Imponibles:";
            // 
            // textFamiliar
            // 
            this.textFamiliar.Location = new System.Drawing.Point(452, 111);
            this.textFamiliar.Name = "textFamiliar";
            this.textFamiliar.Size = new System.Drawing.Size(200, 22);
            this.textFamiliar.TabIndex = 22;
            this.textFamiliar.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Asignacion Familiar:";
            // 
            // textMovilizacion
            // 
            this.textMovilizacion.Location = new System.Drawing.Point(452, 139);
            this.textMovilizacion.Name = "textMovilizacion";
            this.textMovilizacion.Size = new System.Drawing.Size(200, 22);
            this.textMovilizacion.TabIndex = 24;
            this.textMovilizacion.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Movilización:";
            // 
            // textCargas
            // 
            this.textCargas.Location = new System.Drawing.Point(402, 111);
            this.textCargas.Name = "textCargas";
            this.textCargas.Size = new System.Drawing.Size(44, 22);
            this.textCargas.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(337, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Cargas:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelHaberes);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(18, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 35);
            this.panel1.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(62, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "TOTAL HABERES";
            // 
            // labelHaberes
            // 
            this.labelHaberes.AutoSize = true;
            this.labelHaberes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaberes.ForeColor = System.Drawing.Color.Black;
            this.labelHaberes.Location = new System.Drawing.Point(461, 7);
            this.labelHaberes.Name = "labelHaberes";
            this.labelHaberes.Size = new System.Drawing.Size(24, 25);
            this.labelHaberes.TabIndex = 1;
            this.labelHaberes.Text = "$";
            this.labelHaberes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Location = new System.Drawing.Point(22, 656);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(214, 33);
            this.BotonCalcular.TabIndex = 26;
            this.BotonCalcular.Text = "CALCULAR LIQUIDACION";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.textOtrosDescuentos);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textOtrosPrev);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textVoluntarioAFP);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textSalud);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textAFP);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(18, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 217);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DESCUENTOS";
            // 
            // textOtrosDescuentos
            // 
            this.textOtrosDescuentos.Location = new System.Drawing.Point(452, 139);
            this.textOtrosDescuentos.Name = "textOtrosDescuentos";
            this.textOtrosDescuentos.Size = new System.Drawing.Size(200, 22);
            this.textOtrosDescuentos.TabIndex = 24;
            this.textOtrosDescuentos.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(64, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Otros Descuentos:";
            // 
            // textOtrosPrev
            // 
            this.textOtrosPrev.Location = new System.Drawing.Point(452, 111);
            this.textOtrosPrev.Name = "textOtrosPrev";
            this.textOtrosPrev.Size = new System.Drawing.Size(200, 22);
            this.textOtrosPrev.TabIndex = 22;
            this.textOtrosPrev.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(64, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(243, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Otros descuentos Previcionales:";
            // 
            // textVoluntarioAFP
            // 
            this.textVoluntarioAFP.Location = new System.Drawing.Point(452, 83);
            this.textVoluntarioAFP.Name = "textVoluntarioAFP";
            this.textVoluntarioAFP.Size = new System.Drawing.Size(200, 22);
            this.textVoluntarioAFP.TabIndex = 20;
            this.textVoluntarioAFP.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(64, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(345, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Cotizacion Voluntaria y cuenta de Ahorro AFP:";
            // 
            // textSalud
            // 
            this.textSalud.Location = new System.Drawing.Point(452, 55);
            this.textSalud.Name = "textSalud";
            this.textSalud.Size = new System.Drawing.Size(200, 22);
            this.textSalud.TabIndex = 18;
            this.textSalud.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(64, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "Cotización Salud:";
            // 
            // textAFP
            // 
            this.textAFP.Location = new System.Drawing.Point(452, 27);
            this.textAFP.Name = "textAFP";
            this.textAFP.Size = new System.Drawing.Size(200, 22);
            this.textAFP.TabIndex = 16;
            this.textAFP.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(64, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Cotización Previsional:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(461, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 25);
            this.label20.TabIndex = 1;
            this.label20.Text = "$";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 35);
            this.panel2.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(62, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(240, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "TOTAL DESCUENTOS";
            // 
            // BotonPDF
            // 
            this.BotonPDF.Location = new System.Drawing.Point(280, 656);
            this.BotonPDF.Name = "BotonPDF";
            this.BotonPDF.Size = new System.Drawing.Size(214, 33);
            this.BotonPDF.TabIndex = 27;
            this.BotonPDF.Text = "GUARDAR EN PFD";
            this.BotonPDF.UseVisualStyleBackColor = true;
            // 
            // comboCorrelativo
            // 
            this.comboCorrelativo.ForeColor = System.Drawing.Color.Black;
            this.comboCorrelativo.FormattingEnabled = true;
            this.comboCorrelativo.Location = new System.Drawing.Point(662, 41);
            this.comboCorrelativo.Name = "comboCorrelativo";
            this.comboCorrelativo.Size = new System.Drawing.Size(83, 24);
            this.comboCorrelativo.TabIndex = 17;
            this.comboCorrelativo.SelectedIndexChanged += new System.EventHandler(this.comboCorrelativo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Buscar por Correlativo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 907);
            this.Controls.Add(this.comboCorrelativo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BotonPDF);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LIQUIDACION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tRABAJADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALUDToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboRut;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textCargas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMovilizacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textFamiliar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTotalImponible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textOtrosImponibles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHaberes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BotonCalcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textOtrosDescuentos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textOtrosPrev;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textVoluntarioAFP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textSalud;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textAFP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BotonPDF;
        private System.Windows.Forms.ComboBox comboCorrelativo;
        private System.Windows.Forms.Label label5;
    }
}

