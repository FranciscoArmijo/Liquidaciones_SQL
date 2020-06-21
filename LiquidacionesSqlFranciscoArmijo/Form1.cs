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
           // objeto_conect.Open();
           // string rut = textBoxRut.Text.Substring(0,8)+textAnio.Text+textMes.Text;
           // string sqlinsertar = "insert into liquidaciones(rut,nombre,mes,anio,base, identificador2) values ('" + textBoxRut.Text + "', '" + textBoxNombre.Text + "','" + textMes.Text + "'," + textAnio.Text + ", " + textSueldo.Text + ",'" + rut + "')";
            //MessageBox.Show(sqlinsertar);
           // SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
           // tabla_transito.Clear();
           // sentencia.Fill(tabla_transito);
           // objeto_conect.Close();
        }
        private void botonMostrar_Click(object sender, EventArgs e)
        {
             objeto_conect.Open();
            SqlDataAdapter sentencia = new SqlDataAdapter("select * from LiquidacionesFranciscoArmijo", objeto_conect);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand comando_rut = new SqlCommand("select rut from Datos_personales", objeto_conect);
            SqlCommand comando_correlativo = new SqlCommand("select Correlativo from LiquidacionesFranciscoArmijo", objeto_conect);
            objeto_conect.Open();
            SqlDataReader datos = comando_rut.ExecuteReader();
            
            while (datos.Read())
            {
                // lee cada registro y lo deja en col combobox, los datos se entregan como un vector
                comboRut.Items.Add(datos["rut"].ToString());
            }
            datos.Close();
            SqlDataReader datosCorrelativos = comando_correlativo.ExecuteReader();
            while (datosCorrelativos.Read())
            {
                comboCorrelativo.Items.Add(datosCorrelativos["Correlativo"].ToString());
            }
            datosCorrelativos.Close();
            objeto_conect.Close();
        }

        private void comboRut_SelectedIndexChanged(object sender, EventArgs e)
        {
            objeto_conect.Open();
            SqlCommand comandoNombreTrabajador = new SqlCommand("select nombre_trabajador, apellido_trabajador, Sueldo_Base, N_cargas from Datos_personales where rut = '" + comboRut.Text+"'", objeto_conect);
           //sqldatareader crea un arreglo con lso datos de la DB y los indices son las comunas de la tabla
            SqlDataReader dataTrabajador = comandoNombreTrabajador.ExecuteReader();
            while (dataTrabajador.Read())
            {
                textBoxNombre.Text = Convert.ToString(dataTrabajador["nombre_Trabajador"]) + " " + Convert.ToString(dataTrabajador["apellido_trabajador"]);
                textBase.Text = Convert.ToString(dataTrabajador["Sueldo_Base"]);
                textCargas.Text = Convert.ToString(dataTrabajador["N_cargas"]);
            }
            dataTrabajador.Close();
            objeto_conect.Close();

        }

        private void textAnio_Click(object sender, EventArgs e)
        {

        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            textTotalImponible.Text =Convert.ToString(Convert.ToInt32(textBase.Text) + Convert.ToInt32(textOtrosImponibles.Text));
            labelHaberes.Text = Convert.ToString(Convert.ToInt32(textTotalImponible.Text) + Convert.ToInt32(textFamiliar.Text) + Convert.ToInt32(textMovilizacion.Text));
        }

        private void comboCorrelativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            objeto_conect.Open();
            SqlCommand comandoLiquidaciones = new SqlCommand("select * from LiquidacionesFranciscoArmijo where Correlativo = '"+comboCorrelativo.Text +"'", objeto_conect);
            SqlDataReader dataLiquidaciones = comandoLiquidaciones.ExecuteReader();
            while (dataLiquidaciones.Read())
            {
                comboRut.Text = Convert.ToString(dataLiquidaciones["Rut_trabajador"]);
                textBoxNombre.Text = Convert.ToString(dataLiquidaciones["Nombre_Trabajador"]);
                textAnio.Text = Convert.ToString(dataLiquidaciones["Ano_remuneracion"]);
                comboMes.Text = Convert.ToString(dataLiquidaciones["Mes_remuneracion"]);
                textBase.Text = Convert.ToString(dataLiquidaciones["Sueldo_Base"]);
                textOtrosImponibles.Text = Convert.ToString(dataLiquidaciones["Otros_Ingresos"]);
                textCargas.Text = Convert.ToString(dataLiquidaciones["N_cargas"]);
                textMovilizacion.Text = Convert.ToString(dataLiquidaciones["Movilizacion"]);

            }
            objeto_conect.Close();
        }
    }
}
