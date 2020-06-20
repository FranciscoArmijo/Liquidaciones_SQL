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
    public partial class Trabajador : Form
    {
        public Trabajador()
        {
            InitializeComponent();
        }
        SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP LEONES\SEMESTRE3\PROGRAMACION 2\140620 TAREA BASES SQL\LiquidacionesSqlFranciscoArmijo\LiquidacionesSqlFranciscoArmijo\BaseFranciscoArmijo.mdf; Integrated Security = True");
        DataTable tabla_transito = new DataTable();

        private void Trabajador_Load(object sender, EventArgs e)
        {
            SqlCommand comando_afp = new SqlCommand("select nombre_AFP from Tabla_descuento_afp", objeto_conect);
            SqlCommand comando_salud = new SqlCommand("select nombre_prevision from Tabla_salud", objeto_conect);
            objeto_conect.Open();
            //se crea un comando para buscar los datos que necesito y el sqlreader los leera
            SqlDataReader datos = comando_afp.ExecuteReader();
            while (datos.Read())
            {
                // lee cada registro y lo deja en col combobox, los datos se entregan como un vector
                comboAFP.Items.Add(datos["nombre_AFP"].ToString());
            }
            datos.Close();
            SqlDataReader datos_salud = comando_salud.ExecuteReader();
            while (datos_salud.Read())
            {
                // lee cada registro y lo deja en col combobox, los datos se entregan como un vector
                comboSalud.Items.Add(datos_salud["nombre_prevision"].ToString());
            }

            objeto_conect.Close();
        }

        private void comboAFP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboPlanAFP.Items.Clear();
            objeto_conect.Open();
            SqlCommand comando_afp_plan = new SqlCommand("select codigo_plan from Tabla_descuento_afp where nombre_AFP = '" +comboAFP.Text+ "'", objeto_conect);
            SqlDataReader datos2 = comando_afp_plan.ExecuteReader();
            while (datos2.Read())
            {
                // lee cada registro y lo deja en col combobox, los datos se entregan como un vector
                comboPlanAFP.Items.Add(datos2["codigo_plan"].ToString());
            }
            objeto_conect.Close();
        }

        private void comboPlanSalud_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboPlanSalud.Items.Clear();
            objeto_conect.Open();
            SqlCommand comando_salud_plan = new SqlCommand("select codigo_salud from Tabla_salud where nombre_prevision = '" + comboSalud.Text + "'", objeto_conect);
           
            SqlDataReader datos2 = comando_salud_plan.ExecuteReader();
            
            while (datos2.Read())
            {
                // lee cada registro y lo deja en col combobox, los datos se entregan como un vector
                comboPlanSalud.Items.Add(datos2["codigo_salud"].ToString());
            }
            objeto_conect.Close();
        }
    }
}
