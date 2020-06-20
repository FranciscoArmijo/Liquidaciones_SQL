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
    public partial class Afp : Form
    {
        public Afp()
        {
            InitializeComponent();
        }
        SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP LEONES\SEMESTRE3\PROGRAMACION 2\140620 TAREA BASES SQL\LiquidacionesSqlFranciscoArmijo\LiquidacionesSqlFranciscoArmijo\BaseFranciscoArmijo.mdf; Integrated Security = True");
        DataTable tabla_transito = new DataTable();
        private void Afp_Load(object sender, EventArgs e)
        {
            
           
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            objeto_conect.Open();
            SqlDataAdapter sentencia = new SqlDataAdapter("select * from Tabla_descuento_afp", objeto_conect);
            tabla_transito.Clear();
            sentencia.Fill(tabla_transito);
            dataGridView1.DataSource = tabla_transito;
            objeto_conect.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (textNombreAFP.Text == "" || textPlan.Text == "" || textDescuentoPlan.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR TODOS LOS DATOS SOLICITADOS", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sqlinsertar = "insert into Tabla_descuento_afp(nombre_AFP,nombre_plan,descuento_AFP) values ('" + textNombreAFP.Text + "','" + textPlan.Text + "'," + textDescuentoPlan.Text + ")";
                SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
                tabla_transito.Clear();
                sentencia.Fill(tabla_transito);
                objeto_conect.Close();
                MessageBox.Show("Datos agregados correctamente", "Datos Agregados", MessageBoxButtons.OK);
                textNombreAFP.Text = "";
                textPlan.Text = "";
                textDescuentoPlan.Text = "";
            }
        }
    }
}
