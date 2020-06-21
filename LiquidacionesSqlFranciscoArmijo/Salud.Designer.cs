namespace LiquidacionesSqlFranciscoArmijo
{
    partial class Salud
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.textPlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombrePrevision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Plan Salud";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 288);
            this.dataGridView1.TabIndex = 35;
            // 
            // botonMostrar
            // 
            this.botonMostrar.BackColor = System.Drawing.Color.DarkGray;
            this.botonMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonMostrar.Location = new System.Drawing.Point(179, 204);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(255, 44);
            this.botonMostrar.TabIndex = 34;
            this.botonMostrar.Text = "MOSTRAR PLANES";
            this.botonMostrar.UseVisualStyleBackColor = false;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.DarkGray;
            this.botonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonGuardar.Location = new System.Drawing.Point(179, 154);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(255, 44);
            this.botonGuardar.TabIndex = 33;
            this.botonGuardar.Text = "GUARDAR PLAN SALUD";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // textPlan
            // 
            this.textPlan.Location = new System.Drawing.Point(440, 69);
            this.textPlan.Name = "textPlan";
            this.textPlan.Size = new System.Drawing.Size(180, 22);
            this.textPlan.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre Plan:  ";
            // 
            // textNombrePrevision
            // 
            this.textNombrePrevision.Location = new System.Drawing.Point(145, 69);
            this.textNombrePrevision.Name = "textNombrePrevision";
            this.textNombrePrevision.Size = new System.Drawing.Size(163, 22);
            this.textNombrePrevision.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre Prevision: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 59);
            this.panel1.TabIndex = 26;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(145, 110);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(163, 22);
            this.textValor.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Valor del plan:  ";
            // 
            // Salud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 555);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.textPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombrePrevision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Salud";
            this.Text = "Salud";
            this.Load += new System.EventHandler(this.Salud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonMostrar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.TextBox textPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombrePrevision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label6;
    }
}