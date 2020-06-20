using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        }

        private void comboPlanSalud_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboPlanSalud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPlanSalud.Text = "";
            comboPlanSalud.Items.Clear();
            objeto_conect.Open();
            SqlCommand comando_salud_plan = new SqlCommand("select codigo_salud from Tabla_salud where nombre_prevision = '" + comboSalud.Text + "'", objeto_conect);
            SqlDataReader datos3 = comando_salud_plan.ExecuteReader();
            while (datos3.Read())
            {
                // lee cada registro y lo deja en col combobox, los datos se entregan como un vector
                comboPlanSalud.Items.Add(datos3["codigo_salud"].ToString());
            }
            objeto_conect.Close();
        }
        private void comboAFP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPlanAFP.Text = "";
            comboPlanAFP.Items.Clear();
            objeto_conect.Open();
            SqlCommand comando_afp_plan = new SqlCommand("select codigo_plan from Tabla_descuento_afp where nombre_AFP = '" + comboAFP.Text + "'", objeto_conect);
            SqlDataReader datos2 = comando_afp_plan.ExecuteReader();
            while (datos2.Read())
            {
                // lee cada registro y lo deja en col combobox, los datos se entregan como un vector
                comboPlanAFP.Items.Add(datos2["codigo_plan"].ToString());
            }
            objeto_conect.Close();
        }
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string rut;
            rut = textRut.Text;
            if (textNombre.Text =="" || textRut.Text=="" || textApellido.Text=="" || textCargas.Text==""||comboAFP.Text==""||comboPlanAFP.Text==""||textSueldoBase.Text==""||comboSalud.Text==""|| comboPlanSalud.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR TODOS LOS DATOS", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rut.Length < 10)
                {
                    while (rut.Length != 10)
                    {
                        rut = "0" + rut;
                    }
                }
                double suma = 0;
                double divisionDec = 0;
                int divisionEnt = 0;
                double valorDec = 0;
                double resta11 = 0;
                int digito = 0;
                string digitok = "";
                int[] constantes = { 3, 2, 7, 6, 5, 4, 3, 2 };
                int[] rutarreglo;
                rutarreglo = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    rutarreglo[i] = Int32.Parse(rut[i].ToString());
                    suma = suma + (rutarreglo[i] * constantes[i]);
                }
                divisionDec = suma / 11;
                divisionEnt = (int)divisionDec;
                valorDec = divisionDec - divisionEnt;
                resta11 = 11 - (11 * (valorDec));
                digito = (int)Math.Round(resta11, 0);
                if (digito == 10)
                {
                    digitok = "k";
                }
                if (digito == 11)
                {
                    digito = 0;
                }
                if (Convert.ToString(digito) == Convert.ToString(rut[9]) || digitok == Convert.ToString(rut[9]))
                {
                    string sqlinsertar = "insert into Datos_personales(rut,codigo_plan_afp,codigo_plan_salud,nombre_trabajador,apellido_trabajador, sueldo_base,n_cargas) values ('" + textRut.Text + "'," + comboPlanAFP.Text + "," + comboPlanSalud.Text + ",'" + textNombre.Text + "', '" + textApellido.Text + "'," + textSueldoBase.Text + "," + textCargas.Text + ")";
                    SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
                    tabla_transito.Clear();
                    sentencia.Fill(tabla_transito);
                    objeto_conect.Close();
                    MessageBox.Show("Datos agregados correctamente", "Datos Agregados", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("RUT INCORRECTO", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            objeto_conect.Open();
            SqlDataAdapter sentencia = new SqlDataAdapter("select * from Datos_personales", objeto_conect);
            tabla_transito.Clear();
            sentencia.Fill(tabla_transito);
            dataGridView1.DataSource = tabla_transito;
            objeto_conect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
