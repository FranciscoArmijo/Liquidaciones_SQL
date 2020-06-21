using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LiquidacionesSqlFranciscoArmijo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //se crea nueva conexion con la ruta de acceso a la base de datos
        SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP LEONES\SEMESTRE3\PROGRAMACION 2\140620 TAREA BASES SQL\LiquidacionesSqlFranciscoArmijo\LiquidacionesSqlFranciscoArmijo\BaseFranciscoArmijo.mdf; Integrated Security = True");
       //crear datatable global
        DataTable tabla_transito = new DataTable();
        private void botonGuardar_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            objeto_conect.Open();
            string rut = textBoxRut.Text.Substring(0,8)+textAnio.Text+textMes.Text;
            string sqlinsertar = "insert into liquidaciones(rut,nombre,mes,anio,base, identificador2) values ('" + textBoxRut.Text + "', '" + textBoxNombre.Text + "','" + textMes.Text + "'," + textAnio.Text + ", " + textSueldo.Text + ",'" + rut + "')";
            //MessageBox.Show(sqlinsertar);
            SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
            tabla_transito.Clear();
            sentencia.Fill(tabla_transito);
            objeto_conect.Close();
        }
        private void botonMostrar_Click(object sender, EventArgs e)
        {
             objeto_conect.Open();
            SqlDataAdapter sentencia = new SqlDataAdapter("select * from liquidaciones", objeto_conect);
            tabla_transito.Clear();
            sentencia.Fill(tabla_transito);
            dataGridView1.DataSource = tabla_transito;
            objeto_conect.Close();
        }

        private void tRABAJADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form trabajador = new Trabajador();
            trabajador.Show();
        }

        private void aPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form afp = new Afp();
            afp.Show();
        }

        private void sALUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form salud = new Salud();
            salud.Show();
        }
    }
}
