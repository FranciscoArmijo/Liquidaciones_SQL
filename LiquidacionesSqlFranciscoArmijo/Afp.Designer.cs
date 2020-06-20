namespace LiquidacionesSqlFranciscoArmijo
{
    partial class Afp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescuentoPlan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombreAFP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 59);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(319, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Plan AFP";
            // 
            // textDescuentoPlan
            // 
            this.textDescuentoPlan.Location = new System.Drawing.Point(714, 77);
            this.textDescuentoPlan.Name = "textDescuentoPlan";
            this.textDescuentoPlan.Size = new System.Drawing.Size(112, 22);
            this.textDescuentoPlan.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descuento Plan: ";
            // 
            // textPlan
            // 
            this.textPlan.Location = new System.Drawing.Point(411, 77);
            this.textPlan.Name = "textPlan";
            this.textPlan.Size = new System.Drawing.Size(146, 22);
            this.textPlan.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre Plan:  ";
            // 
            // textNombreAFP
            // 
            this.textNombreAFP.Location = new System.Drawing.Point(120, 77);
            this.textNombreAFP.Name = "textNombreAFP";
            this.textNombreAFP.Size = new System.Drawing.Size(163, 22);
            this.textNombreAFP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre AFP: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 246);
            this.dataGridView1.TabIndex = 25;
            // 
            // botonMostrar
            // 
            this.botonMostrar.BackColor = System.Drawing.Color.DarkGray;
            this.botonMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonMostrar.Location = new System.Drawing.Point(294, 167);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(255, 44);
            this.botonMostrar.TabIndex = 24;
            this.botonMostrar.Text = "MOSTRAR PLANES";
            this.botonMostrar.UseVisualStyleBackColor = false;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.DarkGray;
            this.botonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonGuardar.Location = new System.Drawing.Point(294, 117);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(255, 44);
            this.botonGuardar.TabIndex = 23;
            this.botonGuardar.Text = "GUARDAR PLAN AFP";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // Afp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.textDescuentoPlan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombreAFP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Afp";
            this.Text = "Afp";
            this.Load += new System.EventHandler(this.Afp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDescuentoPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombreAFP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonMostrar;
        private System.Windows.Forms.Button botonGuardar;
    }
}