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
    public partial class Form2 : Form
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
        
        public Form2()
        {
            InitializeComponent();
            try
            {
                cadenaConexion = "Server = localhost; Database = liga; Uid = root; Pwd = root ; Port = 3306;";
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
        {//Botón para ver todos los equipos
            sentenciaSQL = "SELECT nombre, ciudad, web, puntos FROM equipos;";
            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
            //Metemos un if para que pregunte si hemos presionado el boton nos muestre
            //El resultado que pedimos en la consulta.
            // Si metemos un if nos sale el ultimo de la lista?.
            while (resultado.Read())
            {
                label1.Text = resultado.GetString("nombre") + " " + resultado.GetString("ciudad");

            }
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();
            //label1.Text = sentenciaSQL;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sentenciaSQL = "SELECT nombre, puntos FROM equipos WHERE puntos = (SELECT MAX(puntos) FROM liga.equipos);";
            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();
            label1.Text = sentenciaSQL;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sentenciaSQL = "SELECT nombre, puntos FROM equipos WHERE puntos = (SELECT MIN(puntos) FROM liga.equipos);";
            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();
            label1.Text = sentenciaSQL;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sentenciaSQL = "SELECT nombre, web FROM equipos;";
            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();
            label1.Text = sentenciaSQL;
        }

    }
}
