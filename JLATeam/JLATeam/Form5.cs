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
    public partial class Form5 : Form
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

        public Form5()
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


            int cod_cuenta_maximo = 0;
            sentenciaSQL = "SELECT MAX(cod_cuenta) from cuentas";
            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
            if (resultado.Read())
            {
                cod_cuenta_maximo = resultado.GetInt32(0);
                cod_cuenta_maximo++;
            }


            
            sentenciaSQL =
                "INSERT INTO cuentas (tipo, fecha_creacion, saldo, cod_cuenta)" +
                "VALUES (" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text +  "," + textBox4.Text +")"; 
                ;
                
                

            conexion.Close();
            conexion.Open();

            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 v3 = new Form4();
            this.Hide();
            v3.Show();
        }
    }
}
