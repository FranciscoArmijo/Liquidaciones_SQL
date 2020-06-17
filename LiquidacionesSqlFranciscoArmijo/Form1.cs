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

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            //se crea nueva conexion con la ruta de acceso a la base de datos
            SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP LEONES\SEMESTRE3\PROGRAMACION 2\140620 TAREA BASES SQL\LiquidacionesSqlFranciscoArmijo\LiquidacionesSqlFranciscoArmijo\BaseFranciscoArmijo.mdf; Integrated Security = True");
            objeto_conect.Open();
            DataTable tabla_transito = new DataTable();
            SqlDataAdapter sentencia = new SqlDataAdapter("insert into liquidaciones(rut,nombre,mes,anio,base) values ('12345678-9', 'Francsico','01',2020, 150000)", objeto_conect);
            tabla_transito.Clear();
            sentencia.Fill(tabla_transito);
            objeto_conect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP LEONES\SEMESTRE3\PROGRAMACION 2\140620 TAREA BASES SQL\LiquidacionesSqlFranciscoArmijo\LiquidacionesSqlFranciscoArmijo\BaseFranciscoArmijo.mdf; Integrated Security = True");
            objeto_conect.Open();
            DataTable tabla_transito = new DataTable();
            string rut = textBoxRut.Text.Substring(0,8)+textAnio.Text+textMes.Text;
            string sqlinsertar = "insert into liquidaciones(rut,nombre,mes,anio,base, identificador2) values ('"+ textBoxRut.Text +"', '"+textBoxNombre.Text +"','"+textMes.Text+"',"+textAnio.Text +", "+textSueldo.Text+",'"+rut+"')";
            //MessageBox.Show(sqlinsertar);
            SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
            tabla_transito.Clear();
            sentencia.Fill(tabla_transito);
            objeto_conect.Close();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP LEONES\SEMESTRE3\PROGRAMACION 2\140620 TAREA BASES SQL\LiquidacionesSqlFranciscoArmijo\LiquidacionesSqlFranciscoArmijo\BaseFranciscoArmijo.mdf; Integrated Security = True");
            objeto_conect.Open();
            DataTable tabla_transito = new DataTable();
            SqlDataAdapter sentencia = new SqlDataAdapter("select * from liquidaciones", objeto_conect);
            tabla_transito.Clear();
            sentencia.Fill(tabla_transito);
            dataGridView1.DataSource = tabla_transito;
            objeto_conect.Close();
        }
    }
}
