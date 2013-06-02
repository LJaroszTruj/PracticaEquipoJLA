using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace JLATeam
{
    public partial class Form4 : Form
    {
        //La línea que guarda la IP del servidor MySql, el usuario y la pass
        String cadenaConexion;

        //Conector que almacena la conexión a la BBDD
        MySqlConnection conexion;

        //Comando que quiero que se ejecute
        MySqlCommand comando;

        //Consulta
        String sentenciaSQL;

        //Resultado de la consulta
        MySqlDataReader resultado;


        public Form4()
        {
            InitializeComponent();
            try
            {
                cadenaConexion = "Server = localhost; Database = ebanca; Uid = root; Pwd = root ; Port = 3306;";
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception) { }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
            this.Hide();
            v1.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {//Botón para ver todas las cuentas

            label2.Text = "0";

            sentenciaSQL = "SELECT * FROM cuentas;";

            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                label2.Text += resultado.GetString("cod_cuenta") + " " + resultado.GetString("saldo") + "  " + resultado.GetString("fecha_creacion") + "\n";



            }
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label2.Text = "0";

            sentenciaSQL = "SELECT * FROM movimientos;";

            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
           
            while (resultado.Read())
            {
                label2.Text += resultado.GetString("cod_cuenta") + " " + resultado.GetString("dni") + "  " + resultado.GetString("cantidad") + "  " + resultado.GetString("id_movimiento") + "\n";



            }
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "0";

            sentenciaSQL = "SELECT * FROM clientes;";

            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
           
            while (resultado.Read())
            {
                label2.Text += resultado.GetString("codigo_cliente") + " " + resultado.GetString("dni") + "  " + resultado.GetString("nombre") + "  " + resultado.GetString("apellido1") + "\n";



            }
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                Form5 v2 = new Form5();
                this.Hide();
                v2.Show();
            
        }
        }

        



    
}
